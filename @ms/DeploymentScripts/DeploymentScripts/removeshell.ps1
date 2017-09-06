# This script removes shells from a database.

param (
	[Parameter(Mandatory=$True,Position=1,HelpMessage="Database server containing the database to be updated")]
    [string]$dbserver, 
	
	[ValidateSet('uat_optimizeware','staging_optimizeware')]
	[Parameter(Mandatory=$True,Position=2,HelpMessage="Database from which shell will be removed")]
    [string]$database, 
	
	[Parameter(Mandatory=$True,Position=3,HelpMessage="Org references of the shells that will be removed")]
    [string[]]$shells
)

foreach ($shell in $shells) {
   write-host "Removing $shell from $database on $dbserver"
   
   $tsql = "EXEC $database..Client_DeleteAllData '$shell'"
   
   Invoke-Sqlcmd -Query $tsql -ServerInstance $dbserver -Verbose -QueryTimeout 60000
}
