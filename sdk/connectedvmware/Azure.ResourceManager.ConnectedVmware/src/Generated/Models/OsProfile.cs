// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> Defines the resource properties. </summary>
    public partial class OsProfile
    {
        /// <summary> Initializes a new instance of OsProfile. </summary>
        public OsProfile()
        {
        }

        /// <summary> Initializes a new instance of OsProfile. </summary>
        /// <param name="computerName"> Gets or sets computer name. </param>
        /// <param name="adminUsername"> Gets or sets administrator username. </param>
        /// <param name="adminPassword"> Gets or sets administrator password. </param>
        /// <param name="osType"> Gets or sets the type of the os. </param>
        /// <param name="osName"> Gets or sets os name. </param>
        /// <param name="toolsRunningStatus"> Gets or sets the current running status of VMware Tools running in the guest operating system. </param>
        /// <param name="toolsVersionStatus"> Gets or sets the current version status of VMware Tools installed in the guest operating system. </param>
        /// <param name="toolsVersion"> Gets or sets the current version of VMware Tools. </param>
        internal OsProfile(string computerName, string adminUsername, string adminPassword, OsType? osType, string osName, string toolsRunningStatus, string toolsVersionStatus, string toolsVersion)
        {
            ComputerName = computerName;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            OsType = osType;
            OsName = osName;
            ToolsRunningStatus = toolsRunningStatus;
            ToolsVersionStatus = toolsVersionStatus;
            ToolsVersion = toolsVersion;
        }

        /// <summary> Gets or sets computer name. </summary>
        public string ComputerName { get; set; }
        /// <summary> Gets or sets administrator username. </summary>
        public string AdminUsername { get; set; }
        /// <summary> Gets or sets administrator password. </summary>
        public string AdminPassword { get; set; }
        /// <summary> Gets or sets the type of the os. </summary>
        public OsType? OsType { get; set; }
        /// <summary> Gets or sets os name. </summary>
        public string OsName { get; }
        /// <summary> Gets or sets the current running status of VMware Tools running in the guest operating system. </summary>
        public string ToolsRunningStatus { get; }
        /// <summary> Gets or sets the current version status of VMware Tools installed in the guest operating system. </summary>
        public string ToolsVersionStatus { get; }
        /// <summary> Gets or sets the current version of VMware Tools. </summary>
        public string ToolsVersion { get; }
    }
}
