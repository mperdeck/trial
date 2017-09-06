# This script refreshes a database from the live database, mainly by calling the databaserefresh.sql script.

param (
	[Parameter(Mandatory=$True,Position=1,HelpMessage="Database server containing the target database")]
    [string]$dbserver, 
	
	[ValidateSet('uat_optimizeware','staging_optimizeware')]
	[Parameter(Mandatory=$True,Position=2,HelpMessage="Target database that will be refreshed")]
    [string]$database
)

# relative to the folder where this script is executing
$tsqlRelativePath = "databaserefresh.sql"

$tsqlPath = [io.path]::GetFullPath([io.path]::combine($PSScriptRoot, $tsqlRelativePath))
$tsql = [IO.File]::ReadAllText($tsqlPath)
$tsql = $tsql.replace("{{database}}", $database)

Invoke-Sqlcmd -Query $tsql -ServerInstance $dbserver -Verbose -QueryTimeout 60000



