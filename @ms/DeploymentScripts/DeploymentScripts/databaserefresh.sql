-- {{database}} is set to either uat_optimizeware or staging_optimizeware by the Powershell script that uses this file.
-- It is the database that will be refreshed from the live database.
-- Target database and live database are assumed to be on the database server where this script is running.

-- -------------------------------------------------------------
-- IMPORTANT
-- 
-- Do NOT use GO in this script. If you do, the RETURN below (executed if somebody tries to run this script against production)
-- will terminate the current batch, and effectively skip to the next batch. Note that it is GO that terminates one batch and starts another.
--
-- -------------------------------------------------------------

IF '{{database}}' = 'optimizeware'
BEGIN
	RAISERROR ('refreshdatabase.sql - Attempted to run this script against optimizeware (which may be the live database)', 1, 1);
	RETURN
END

USE {{database}}

print '-----------------------------------------------------------'
print 'Drop all tables and views from {{database}}'
print '-----------------------------------------------------------'

DECLARE @tablestodo TABLE
(
  TABLE_NAME  varchar(8000)
)

-- A table cannot be dropped if it has foreign key constraints pointed at it, or if it is
-- referenced by views.
-- The tentacle doesn't have permission to ALTER tables to disable the foreign key constraints.
-- So the code below drop tables and views, and keeps retrying until all the tables and views
-- have been dropped.

INSERT @tablestodo
SELECT TABLE_NAME 
FROM {{database}}.INFORMATION_SCHEMA.TABLES 
WHERE (TABLE_TYPE = 'BASE TABLE') AND TABLE_NAME NOT IN ('sysdiagrams', '__RefactorLog', 'dtproperties')
UNION
SELECT TABLE_NAME 
FROM {{database}}.INFORMATION_SCHEMA.VIEWS 
ORDER BY TABLE_NAME 

DECLARE @tablename VARCHAR(8000)
DECLARE @SQL NVARCHAR(MAX)

WHILE EXISTS(SELECT * FROM @tablestodo)
BEGIN

	DECLARE db_cursor CURSOR FOR
	SELECT TABLE_NAME 
	FROM @tablestodo 

	OPEN db_cursor   
	FETCH NEXT FROM db_cursor INTO @tablename

	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		BEGIN TRY

			-- Cannot specify database name with DROP VIEW.
			--
			-- If @Tablename is a table instead of a view, this will throw an exception, and
			-- the table will be dropped in the catch part
			SELECT @SQL = 'DROP VIEW [dbo].' + QUOTENAME(@TABLENAME) + '';
			EXEC sp_executesql @SQL;

			print 'Dropped view ' + @TABLENAME

			DELETE @tablestodo WHERE TABLE_NAME  = @TABLENAME
		END TRY
		BEGIN CATCH
			BEGIN TRY
				SELECT @SQL = 'DROP TABLE [{{database}}].[dbo].' + QUOTENAME(@TABLENAME) + '';
				EXEC sp_executesql @SQL;

				print 'Dropped table ' + @TABLENAME

				DELETE @tablestodo WHERE TABLE_NAME  = @TABLENAME
			END TRY
			BEGIN CATCH
				-- If we get here, the view or table could not be dropped.
				-- During each iteration of the WHILE loop, more tables and views will be dropped
				-- until all constraints are gone that stopped this view or table from being dropped.
			END CATCH
		END CATCH

		FETCH NEXT FROM db_cursor INTO @tablename
	END   

	CLOSE db_cursor   
	DEALLOCATE db_cursor
END

-- prevent log from filling up
CHECKPOINT 

print '-----------------------------------------------------------'
print 'Copy all tables from optimizeware to {{database}}'
print '-----------------------------------------------------------'

DECLARE @tablestodo2 TABLE
(
  TABLE_NAME  varchar(8000)
)

INSERT @tablestodo2
SELECT TABLE_NAME 
FROM optimizeware.INFORMATION_SCHEMA.TABLES 
WHERE (TABLE_TYPE = 'BASE TABLE') AND TABLE_NAME NOT IN ('sysdiagrams', '__RefactorLog', 'dtproperties')
ORDER BY TABLE_NAME 

WHILE EXISTS(SELECT * FROM @tablestodo2)
BEGIN
	DECLARE db_cursor CURSOR FOR
	SELECT TABLE_NAME 
	FROM @tablestodo2 

	OPEN db_cursor   
	FETCH NEXT FROM db_cursor INTO @tablename

	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		BEGIN TRY
			SELECT @SQL = 'SELECT * INTO [{{database}}].[dbo].' + QUOTENAME(@TABLENAME) + '  FROM [optimizeware].[dbo].' + QUOTENAME(@TABLENAME) + ''
			EXEC sp_executesql @SQL;

			print 'Copied table ' + @TABLENAME

			DELETE @tablestodo2 WHERE TABLE_NAME  = @TABLENAME

			CHECKPOINT 
		END TRY
		BEGIN CATCH
			-- If we get here, there was a foreign key violation.
			-- During the next iterations, the data needed to solve this violation will be selected into
			-- some table, so this table can then receive its data.
		END CATCH

		FETCH NEXT FROM db_cursor INTO @tablename
	END   

	CLOSE db_cursor   
	DEALLOCATE db_cursor
END

print '-----------------------------------------------------------'
print 'Copy all views from optimizeware to {{database}}'
print '-----------------------------------------------------------'

DECLARE @viewstodo TABLE
(
  [name]  varchar(MAX),
  [definition]  varchar(MAX)
)

INSERT @viewstodo
SELECT [name], [definition]
FROM optimizeware.sys.sql_modules AS s
INNER JOIN optimizeware.sys.objects AS o
ON s.[object_id] = o.[object_id]
WHERE o.type_desc = 'VIEW';

DECLARE @name VARCHAR(MAX)
DECLARE @definition NVARCHAR(MAX)

WHILE EXISTS(SELECT * FROM @viewstodo)
BEGIN
	DECLARE db_cursor CURSOR FOR
	SELECT [name], [definition]
	FROM @viewstodo 

	OPEN db_cursor   
	FETCH NEXT FROM db_cursor INTO @name, @definition

	WHILE @@FETCH_STATUS = 0   
	BEGIN   
		BEGIN TRY
			EXEC {{database}}..sp_executesql @definition;

			print 'Copied view ' + @name
			DELETE @viewstodo WHERE [name]  = @name
		END TRY
		BEGIN CATCH
			-- If we get here, the view could not be created because it depends on a view that 
			-- has not yet been copied.
			-- During this or the next iterations, that other view will get created
			-- and then this view can be created.
		END CATCH

		FETCH NEXT FROM db_cursor INTO @name, @definition
	END   

	CLOSE db_cursor   
	DEALLOCATE db_cursor
END

CHECKPOINT 

print '-----------------------------------------------------------'
print 'Copy table constraints from optimizeware to {{database}}'
print '-----------------------------------------------------------'

-- Need to copy the constraints, because User_Insert sproc won't work with one of the default constraints on the
-- custpers table.

DECLARE db_cursor CURSOR FOR
SELECT 'ALTER TABLE ' + OBJECT_SCHEMA_NAME(dc.parent_object_id, DB_ID(N'optimizeware')) + '.' + OBJECT_NAME(dc.parent_object_id, DB_ID(N'optimizeware')) + 
	' ADD CONSTRAINT ' + dc.name + ' DEFAULT(' + definition 
	+ ') FOR ' + c.name
FROM
	optimizeware.sys.default_constraints dc
INNER JOIN 
	optimizeware.sys.columns c ON dc.parent_object_id = c.object_id 
					AND dc.parent_column_id = c.column_id

OPEN db_cursor   
FETCH NEXT FROM db_cursor INTO @sql

WHILE @@FETCH_STATUS = 0   
BEGIN   
	BEGIN TRY
		print @sql
		EXEC {{database}}..sp_executesql @sql;
	END TRY
	BEGIN CATCH
		print ERROR_MESSAGE();
	END CATCH

	FETCH NEXT FROM db_cursor INTO @sql
END   

CLOSE db_cursor   
DEALLOCATE db_cursor

CHECKPOINT 

print '-----------------------------------------------------------'
print 'Ensuring that none of the users are read-only'
print '-----------------------------------------------------------'

UPDATE	dbo.person
SET		read_only_user = 'N'

CHECKPOINT 



