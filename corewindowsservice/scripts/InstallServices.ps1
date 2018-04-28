# This script installs all windows services.
#
# The default parameter values work for a local developer machine.
# So on your local machine, you can just open a Powershell windows (in Admin mode) and run
# cd E:\Dev\DeploymentScripts\ServerConfiguration
# .\InstallServices.ps1


# <<<<<<<<<<<<<<<<<
# add environment parameter

param (
	[Parameter(Mandatory=$False,Position=1,HelpMessage="Path to windows service exe files. Placeholder {exename} gets replaced by the name of the service exe, without the .exe extension.")]
    [string]$windowsServicesExePath = "C:\Dev\trial\corewindowsservice\service\{exename}\bin\net47\{exename}.exe",
    [string]$environment = "Development"
)

# import the names of all services
."$PSScriptRoot\ServiceInfos.ps1"

# $serviceExeName is the name of the executable file of the service, without the .exe extention.
# For example: Decideware.Platform.ServerLogCopierService
Function InstallService([string]$serviceExeName)
{
	$exePath = $windowsServicesExePath -replace "{exename}", $serviceExeName

	if (Get-Service $serviceExeName -ErrorAction SilentlyContinue)
	{
		"Deleting service $serviceExeName"
		sc.exe stop $serviceExeName
		sc.exe delete $serviceExeName
	}
	
	"-------------"
	"Installing service $serviceExeName"
	new-service -Name $serviceExeName -DisplayName $serviceExeName -BinaryPathName $exePath -StartupType Automatic
	
	"-------------"
	"Starting service $serviceExeName"
	Start-Service -Name $serviceExeName
} 

# -------------------------------------
# Install each service here

# <<<<<<<<<<<<<<<<<
[Environment]::SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", $environment, "Process")

foreach ($serviceExeName in $serviceExeFilesWithoutExtension) {
	InstallService $serviceExeName
}









