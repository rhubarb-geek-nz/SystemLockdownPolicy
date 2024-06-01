# SystemLockdownPolicy

Get-SystemLockdownPolicy cmdlet

Inspired by [Add a command which gets the System Lockdown mode information](https://github.com/PowerShell/PowerShell/issues/23799) and in the style of [Get-ExecutionPolicy](https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.security/get-executionpolicy)

```
PS> (Get-SystemLockdownPolicy).GetType().FullName
System.Management.Automation.Security.SystemEnforcementMode
PS> Get-SystemLockdownPolicy
None
```
