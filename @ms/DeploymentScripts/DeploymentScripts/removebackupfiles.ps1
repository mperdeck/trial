# This script removes backup files from a directory.

param (
	[Parameter(Mandatory=$True,Position=1,HelpMessage="Full path of the folder containing the backup files")]
    [string]$backupFolder, 
	
	[Parameter(Mandatory=$False,Position=2,HelpMessage="The most recent files will be kept. This parameter determines how many files are kept.")]
    [int]$nbrKept = 1, 
	
	[Parameter(Mandatory=$False,Position=3,HelpMessage="If true, backup files created less than 24 hours ago never get removed. Caters for multiple deployment attempts in short order.")]
    [int]$keepTodaysFiles = $true
)

$path = $backupFolder

"Removing backup files from $path"

$nbrFiles = (get-childitem $path).count - $nbrKept
if ($nbrFiles -gt 0)
{
    $files = get-childitem -path $path | sort LastWriteTime -Descending | select -last $nbrFiles
    foreach($file in $files)
	{
        if ($keepTodaysFiles)
        {
            $today = [System.DateTime]::Now;
            $fileCreationTime = $file.LastWriteTime;
            $oneDay = new-timespan -days 1

            if ($today - $fileCreationTime -lt $oneDay)
            {

    		    "Did not remove $file because less than a day old. Its creation time: " + $file.LastWriteTime
                continue
            }
        }

	    Try
		{
	        Remove-Item -Force $file.FullName -ErrorAction Stop
		    "Removed backup file $file"
		}
		Catch
		{
		    ">>>>> Could not remove backup file $file"
		    $_.Exception
		}		
	}
}
