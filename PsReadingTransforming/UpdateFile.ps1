# web.config file is a text file with place holder like so {{placeholder}}
# environment.csv has key value pairs, one pair per line. value is separated from key by a single tab character.
# This program reads both files, replaces the placeholders in web.config with the values in environment.csv
# and writes the result back to web.config

Param(
  [Parameter(Mandatory=$True, HelpMessage="File path of web.config file")]
  [string]$webConfigPath,

  [Parameter(Mandatory=$True, HelpMessage="File path of environment.csv file")]
  [string]$environmentCsvPath
)

$webConfigText = Get-Content $webConfigPath -Raw

Get-Content $environmentCsvPath | ForEach-Object {
	$key,$value = $_.split("`t",2)
	$webConfigText = $webConfigText -replace "{{$key}}", $value
}

$webConfigText | Out-File -filePath $webConfigPath -encoding "UTF8" -force





