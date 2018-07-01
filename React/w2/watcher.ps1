$block = {    
    function Do-Something
    {
        param ($message, $event)
        # function to call when event is raised
        # do a robocopy or whatever

        Start-Process cmd.exe "/C echo $("{0} {1}" -f $event.SourceEventArgs.FullPath, $message)&pause"
    }

    $watchedFolder = "C:\Dev\trial\React\w2\w2\wwwroot"
    $watcher = New-Object System.IO.FileSystemWatcher
    $watcher.Path = $watchedFolder

    Register-ObjectEvent -InputObject $watcher -EventName Created -SourceIdentifier File.Created -Action { Do-Something "Created" $event }
    Register-ObjectEvent -InputObject $watcher -EventName Deleted -SourceIdentifier File.Deleted -Action { Do-Something "Deleted" $event }
    Register-ObjectEvent -InputObject $watcher -EventName Changed -SourceIdentifier File.Changed -Action { Do-Something "Changed" $event }
    Register-ObjectEvent -InputObject $watcher -EventName Renamed -SourceIdentifier File.Renamed -Action { Do-Something "Renamed" $event }
}

$encodedBlock = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($block))

Start-Process PowerShell.exe -verb Runas -argumentlist '-WindowStyle Hidden', '-NoExit', '-EncodedCommand', $encodedBlock

