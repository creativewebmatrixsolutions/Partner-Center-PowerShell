// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftgraphmanagedAppRegistration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphmanagedAppRegistration class.
        /// </summary>
        public MicrosoftgraphmanagedAppRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphmanagedAppRegistration class.
        /// </summary>
        /// <param name="createdDateTime">Date and time of creation</param>
        /// <param name="lastSyncDateTime">Date and time of last the app synced
        /// with management service.</param>
        /// <param name="applicationVersion">App version</param>
        /// <param name="managementSdkVersion">App management SDK
        /// version</param>
        /// <param name="platformVersion">Operating System version</param>
        /// <param name="deviceType">Host device type</param>
        /// <param name="deviceTag">App management SDK generated tag, which
        /// helps relate apps hosted on the same device. Not guaranteed to
        /// relate apps in all conditions.</param>
        /// <param name="deviceName">Host device name</param>
        /// <param name="managedDeviceId">The Managed Device identifier of the
        /// host device. Value could be empty even when the host device is
        /// managed.</param>
        /// <param name="azureADDeviceId">The Azure Active Directory Device
        /// identifier of the host device. Value could be empty even when the
        /// host device is Azure Active Directory registered.</param>
        /// <param name="deviceModel">The device model for the current app
        /// registration </param>
        /// <param name="deviceManufacturer">The device manufacturer for the
        /// current app registration </param>
        /// <param name="flaggedReasons">Zero or more reasons an app
        /// registration is flagged. E.g. app running on rooted device</param>
        /// <param name="userId">The user Id to who this app registration
        /// belongs.</param>
        /// <param name="version">Version of the entity.</param>
        public MicrosoftgraphmanagedAppRegistration(string id = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastSyncDateTime = default(System.DateTime?), string applicationVersion = default(string), string managementSdkVersion = default(string), string platformVersion = default(string), string deviceType = default(string), string deviceTag = default(string), string deviceName = default(string), string managedDeviceId = default(string), string azureADDeviceId = default(string), string deviceModel = default(string), string deviceManufacturer = default(string), IList<string> flaggedReasons = default(IList<string>), string userId = default(string), object appIdentifier = default(object), string version = default(string), IList<MicrosoftgraphmanagedAppPolicy> appliedPolicies = default(IList<MicrosoftgraphmanagedAppPolicy>), IList<MicrosoftgraphmanagedAppPolicy> intendedPolicies = default(IList<MicrosoftgraphmanagedAppPolicy>), IList<MicrosoftgraphmanagedAppOperation> operations = default(IList<MicrosoftgraphmanagedAppOperation>))
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastSyncDateTime = lastSyncDateTime;
            ApplicationVersion = applicationVersion;
            ManagementSdkVersion = managementSdkVersion;
            PlatformVersion = platformVersion;
            DeviceType = deviceType;
            DeviceTag = deviceTag;
            DeviceName = deviceName;
            ManagedDeviceId = managedDeviceId;
            AzureADDeviceId = azureADDeviceId;
            DeviceModel = deviceModel;
            DeviceManufacturer = deviceManufacturer;
            FlaggedReasons = flaggedReasons;
            UserId = userId;
            AppIdentifier = appIdentifier;
            Version = version;
            AppliedPolicies = appliedPolicies;
            IntendedPolicies = intendedPolicies;
            Operations = operations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets date and time of creation
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets date and time of last the app synced with management
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "lastSyncDateTime")]
        public System.DateTime? LastSyncDateTime { get; set; }

        /// <summary>
        /// Gets or sets app version
        /// </summary>
        [JsonProperty(PropertyName = "applicationVersion")]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// Gets or sets app management SDK version
        /// </summary>
        [JsonProperty(PropertyName = "managementSdkVersion")]
        public string ManagementSdkVersion { get; set; }

        /// <summary>
        /// Gets or sets operating System version
        /// </summary>
        [JsonProperty(PropertyName = "platformVersion")]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Gets or sets host device type
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or sets app management SDK generated tag, which helps relate
        /// apps hosted on the same device. Not guaranteed to relate apps in
        /// all conditions.
        /// </summary>
        [JsonProperty(PropertyName = "deviceTag")]
        public string DeviceTag { get; set; }

        /// <summary>
        /// Gets or sets host device name
        /// </summary>
        [JsonProperty(PropertyName = "deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// Gets or sets the Managed Device identifier of the host device.
        /// Value could be empty even when the host device is managed.
        /// </summary>
        [JsonProperty(PropertyName = "managedDeviceId")]
        public string ManagedDeviceId { get; set; }

        /// <summary>
        /// Gets or sets the Azure Active Directory Device identifier of the
        /// host device. Value could be empty even when the host device is
        /// Azure Active Directory registered.
        /// </summary>
        [JsonProperty(PropertyName = "azureADDeviceId")]
        public string AzureADDeviceId { get; set; }

        /// <summary>
        /// Gets or sets the device model for the current app registration
        /// </summary>
        [JsonProperty(PropertyName = "deviceModel")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Gets or sets the device manufacturer for the current app
        /// registration
        /// </summary>
        [JsonProperty(PropertyName = "deviceManufacturer")]
        public string DeviceManufacturer { get; set; }

        /// <summary>
        /// Gets or sets zero or more reasons an app registration is flagged.
        /// E.g. app running on rooted device
        /// </summary>
        [JsonProperty(PropertyName = "flaggedReasons")]
        public IList<string> FlaggedReasons { get; set; }

        /// <summary>
        /// Gets or sets the user Id to who this app registration belongs.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appIdentifier")]
        public object AppIdentifier { get; set; }

        /// <summary>
        /// Gets or sets version of the entity.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appliedPolicies")]
        public IList<MicrosoftgraphmanagedAppPolicy> AppliedPolicies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intendedPolicies")]
        public IList<MicrosoftgraphmanagedAppPolicy> IntendedPolicies { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<MicrosoftgraphmanagedAppOperation> Operations { get; set; }

    }
}
