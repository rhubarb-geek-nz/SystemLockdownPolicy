// Copyright (c) 2024 Roger Brown.
// Licensed under the MIT License.

using System.Management.Automation;

namespace RhubarbGeekNz.SystemLockdownPolicy
{
    [Cmdlet(VerbsCommon.Get, "SystemLockdownPolicy")]
    [OutputType("System.Management.Automation.Security.SystemEnforcementMode")]
    sealed public class GetSystemLockdownPolicy : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject(typeof(PSObject).Assembly.GetType("System.Management.Automation.Security.SystemPolicy").GetMethod("GetSystemLockdownPolicy").Invoke(null, null));
        }
    }
}
