# This script delete all active sessions from a database.

param (
	[Parameter(Mandatory=$True,Position=1,HelpMessage="Database server containing the database.")]
    [string]$dbserver, 
	
	[Parameter(Mandatory=$True,Position=2,HelpMessage="Database which has the T-SQL script be executed.")]
    [string]$database
)

write-host "Removing active sessions from $database on $dbserver."
   
$tsql = "EXEC " + $database + ".dbo.SessionView_TerminateActiveSessions"

Invoke-Sqlcmd -Query $tsql -ServerInstance $dbserver -Verbose -QueryTimeout 120
