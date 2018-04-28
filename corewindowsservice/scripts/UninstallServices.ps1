# This script uninstalls all windows services.

param (
)

# import the names of all services
."$PSScriptRoot\ServiceInfos.ps1"

# $serviceExeName is the name of the executable file of the service, without the .exe extention.
# For example: Decideware.Platform.ServerLogCopierService
Function UninstallService([string]$serviceExeName)
{
	if (Get-Service $serviceExeName -ErrorAction SilentlyContinue)
	{
		"-------------"
		"Deleting service $serviceExeName"
		sc.exe stop $serviceExeName
		sc.exe delete $serviceExeName
	}
} 

# -------------------------------------
# Uninstall each service here

foreach ($serviceExeName in $serviceExeFilesWithoutExtension) {
	UninstallService $serviceExeName
}









