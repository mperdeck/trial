# run this in powershell opened in administrator mode
New-EventLog –LogName Application –Source "My Script"

Write-EventLog –LogName Application –Source “My Script” –EntryType Information –EventID 1  –Message “This is a test message.”
