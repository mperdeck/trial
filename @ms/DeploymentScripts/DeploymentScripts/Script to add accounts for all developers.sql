print '-----------------------------------------------------------'
print 'Add accounts for developers and service personnel to {{database}}'
print '-----------------------------------------------------------'

USE {{database}}

DECLARE @AdditionalAccounts TABLE
(
  title_id VARCHAR(10),
  first_name VARCHAR(15),
  initials VARCHAR(5),
  surname VARCHAR(20),
  email NVARCHAR(80)
)

INSERT @AdditionalAccounts VALUES ('Mr', 'Matt', '', 'Perdeck', 'mperdeck@decideware.com')
INSERT @AdditionalAccounts VALUES ('Mr', 'Jin', '', 'Wen', 'jwen@decideware.com')
INSERT @AdditionalAccounts VALUES ('Mr', 'Daniel', '', 'Cheney', 'dcheney@decideware.com')
INSERT @AdditionalAccounts VALUES ('Mr', 'Yan', '', 'Liang', 'yliang@decideware.com')
INSERT @AdditionalAccounts VALUES ('Mr', 'Edward', '', 'Hodges', 'ehodges@decideware.com')
INSERT @AdditionalAccounts VALUES ('Ms', 'Simone', '', 'Banks', 'sbanks@decideware.com')
INSERT @AdditionalAccounts VALUES ('Mr', 'Andrew', '', 'Holmes', 'aholmes@decideware.com')
INSERT @AdditionalAccounts VALUES ('Ms', 'Zorina', '', 'Crooks', 'zcrooks@decideware.com')
INSERT @AdditionalAccounts VALUES ('Mr', 'Richard', '', 'Benyon', 'rbenyon@decideware.com')
INSERT @AdditionalAccounts VALUES ('Ms', 'Michelle', '', 'Galbraith', 'mgalbraith@decideware.com')

DECLARE @Person table(person_id INT)

DECLARE @title_id VARCHAR(10),
  @first_name VARCHAR(15),
  @initials VARCHAR(5),
  @surname VARCHAR(20),
  @email NVARCHAR(80),
  @random_password VARCHAR(30),
  @password_salt VARCHAR(8),
  @new_salted_hash VARBINARY(64),
  @org_id INT,
  @org_name VARCHAR(50)

-- ------------

-- db_cursor will have a record for each additional account, for each organisation (cartesian product)
-- Those additional accounts that already have both a person record and a custpers record will be skipped
DECLARE db_cursor CURSOR FOR
SELECT aa.title_id, aa.first_name, aa.initials, aa.surname, aa.email, o.org_id, o.org_name
FROM @AdditionalAccounts aa
CROSS JOIN org o
Where o.active='Y' and o.client_supplier='C'

print ''
print '>>>>> Adding developers and service people to those organisations where they do not already have an account'

OPEN db_cursor   
FETCH NEXT FROM db_cursor INTO @title_id, @first_name, @initials, @surname, @email, @org_id, @org_name

WHILE @@FETCH_STATUS = 0   
BEGIN   
	print ''
	print '>>>>> Adding accounts with random password to organisation ' + @org_name + ' for ' + @first_name + ' ' + @surname + ', username: ' + @email 

	-- Creates a record in the person table, and inserts the resulting person_id in @PersonId
	IF NOT EXISTS(SELECT * FROM dbo.person WHERE org_id = @org_id AND email = @email)
	BEGIN
		BEGIN TRY

			SELECT @random_password = CONVERT( VARCHAR, (RAND() + 1) * 10000000 )
			print '      Create admin user in person' 


			DELETE @Person
			INSERT @Person
			EXEC dbo.person_ins_sp  
				@org_id = @org_id, @title_id = @title_id, @first_name = @first_name, @initials = @initials, 
				@surname = @surname, @email = @email, @password = @random_password, @user_code = @email,
				@alternate_password = @random_password, @must_change = 'Y', 
				@access_dbd = 'Y', @access_ro = 'Y', @access_roster = 'Y',
				@access_sow = 'Y', @access_briefing = 'Y', @access_production = 'Y',
				@account_locked = 'N', @active = 'Y', @read_only_user = 'N', @audit_unified_user_name = '',
				@acctype_id = 1, @acctype_id_2 = 1, @acctype_id_3 = 1, @acctype_id_4 = 1, @acctype_id_5 = 1,
				@geography_id = 1, @geography_id_2 = 1, @geography_id_3 = 1, @geography_id_4 = 1, @geography_id_5 = 1, 
				@custorgunit_id = 1, @custorgunit_id_2 = 1, @custorgunit_id_3 = 1, @custorgunit_id_4 = 1, @custorgunit_id_5 = 1,
				@orgunit_id	 = 1, @orgunit_id_2 = 1, @orgunit_id_3 = 1, @orgunit_id_4 = 1, @orgunit_id_5 = 1

			-- Give the new account all the roles
			print '     Add roles to new admin user'
			INSERT INTO dbo.persrole (person_id, rolemst_id)
			SELECT p.person_id, r.rolemst_id
			FROM @Person p
			CROSS JOIN rolemst r

			CHECKPOINT 
		END TRY
		BEGIN CATCH
			print ERROR_MESSAGE();
		END CATCH;
	END

	IF NOT EXISTS(SELECT * FROM dbo.custpers WHERE org_id = @org_id AND email = @email)
	BEGIN

		print '      Create client user in custpers' 
		SELECT @random_password = CONVERT( VARCHAR, (RAND() + 1) * 10000000 )
		EXEC [dbo].[GeneratePasswordSalt] @PasswordSalt=@password_salt OUT
		EXEC [dbo].[GetSaltedPasswordHashValue] @PlainPassword=@random_password, @Salt=@password_salt, @HashValue=@new_salted_hash OUT

		BEGIN TRY
			EXEC dbo.User_Insert  
				@OrgId = @org_id, @LocationId = 1, @JobFunctionId = 1,
				@Title = @title_id, @FirstName = @first_name, @Initials = @initials, 
				@LastName = @surname, @EmailAddress = @email, @Username = @email,
				@IsLockedOut = 'N', @IsActive = 'Y', @FailedLoginAttempts = 0,
				@IsEvaluationPowerUser = 'Y', @IsSelectionPowerUser = 'Y', @IsScopeOfWorkPowerUser = 'Y', 
				@IsBriefingPowerUser = 'Y', @IsProductionPowerUser = 'Y', @CreatedBy=N'Database Refresh',
				@PasswordChangeDate = NULL, @AlternatePasswordChangeDate = NULL, @PasswordIsOtp = 'N',
				@HashedAlternatePassword = NULL, @Hashed256Password = NULL,
				@HashedPassword = @new_salted_hash, @HashedPasswordSalt = @password_salt
		END TRY
		BEGIN CATCH
			print ERROR_MESSAGE();
		END CATCH;
	END

	FETCH NEXT FROM db_cursor INTO @title_id, @first_name, @initials, @surname, @email, @org_id, @org_name
END   

CLOSE db_cursor   
DEALLOCATE db_cursor

CHECKPOINT 
