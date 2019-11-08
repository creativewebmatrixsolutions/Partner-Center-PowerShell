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

    public partial class MicrosoftgraphwindowsProtectionState
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphwindowsProtectionState class.
        /// </summary>
        public MicrosoftgraphwindowsProtectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphwindowsProtectionState class.
        /// </summary>
        /// <param name="malwareProtectionEnabled">Anti malware is enabled or
        /// not</param>
        /// <param name="deviceState">Possible values include: 'clean',
        /// 'fullScanPending', 'rebootPending', 'manualStepsPending',
        /// 'offlineScanPending', 'critical'</param>
        /// <param name="realTimeProtectionEnabled">Real time protection is
        /// enabled or not?</param>
        /// <param name="networkInspectionSystemEnabled">Network inspection
        /// system enabled or not?</param>
        /// <param name="quickScanOverdue">Quick scan overdue or not?</param>
        /// <param name="fullScanOverdue">Full scan overdue or not?</param>
        /// <param name="signatureUpdateOverdue">Signature out of date or
        /// not?</param>
        /// <param name="rebootRequired">Reboot required or not?</param>
        /// <param name="fullScanRequired">Full scan required or not?</param>
        /// <param name="engineVersion">Current endpoint protection engine's
        /// version</param>
        /// <param name="signatureVersion">Current malware definitions
        /// version</param>
        /// <param name="antiMalwareVersion">Current anti malware
        /// version</param>
        /// <param name="lastQuickScanDateTime">Last quick scan
        /// datetime</param>
        /// <param name="lastFullScanDateTime">Last quick scan datetime</param>
        /// <param name="lastQuickScanSignatureVersion">Last quick scan
        /// signature version</param>
        /// <param name="lastFullScanSignatureVersion">Last full scan signature
        /// version</param>
        /// <param name="lastReportedDateTime">Last device health status
        /// reported time</param>
        public MicrosoftgraphwindowsProtectionState(string id = default(string), bool? malwareProtectionEnabled = default(bool?), string deviceState = default(string), bool? realTimeProtectionEnabled = default(bool?), bool? networkInspectionSystemEnabled = default(bool?), bool? quickScanOverdue = default(bool?), bool? fullScanOverdue = default(bool?), bool? signatureUpdateOverdue = default(bool?), bool? rebootRequired = default(bool?), bool? fullScanRequired = default(bool?), string engineVersion = default(string), string signatureVersion = default(string), string antiMalwareVersion = default(string), System.DateTime? lastQuickScanDateTime = default(System.DateTime?), System.DateTime? lastFullScanDateTime = default(System.DateTime?), string lastQuickScanSignatureVersion = default(string), string lastFullScanSignatureVersion = default(string), System.DateTime? lastReportedDateTime = default(System.DateTime?), IList<MicrosoftgraphwindowsDeviceMalwareState> detectedMalwareState = default(IList<MicrosoftgraphwindowsDeviceMalwareState>))
        {
            Id = id;
            MalwareProtectionEnabled = malwareProtectionEnabled;
            DeviceState = deviceState;
            RealTimeProtectionEnabled = realTimeProtectionEnabled;
            NetworkInspectionSystemEnabled = networkInspectionSystemEnabled;
            QuickScanOverdue = quickScanOverdue;
            FullScanOverdue = fullScanOverdue;
            SignatureUpdateOverdue = signatureUpdateOverdue;
            RebootRequired = rebootRequired;
            FullScanRequired = fullScanRequired;
            EngineVersion = engineVersion;
            SignatureVersion = signatureVersion;
            AntiMalwareVersion = antiMalwareVersion;
            LastQuickScanDateTime = lastQuickScanDateTime;
            LastFullScanDateTime = lastFullScanDateTime;
            LastQuickScanSignatureVersion = lastQuickScanSignatureVersion;
            LastFullScanSignatureVersion = lastFullScanSignatureVersion;
            LastReportedDateTime = lastReportedDateTime;
            DetectedMalwareState = detectedMalwareState;
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
        /// Gets or sets anti malware is enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "malwareProtectionEnabled")]
        public bool? MalwareProtectionEnabled { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'clean', 'fullScanPending',
        /// 'rebootPending', 'manualStepsPending', 'offlineScanPending',
        /// 'critical'
        /// </summary>
        [JsonProperty(PropertyName = "deviceState")]
        public string DeviceState { get; set; }

        /// <summary>
        /// Gets or sets real time protection is enabled or not?
        /// </summary>
        [JsonProperty(PropertyName = "realTimeProtectionEnabled")]
        public bool? RealTimeProtectionEnabled { get; set; }

        /// <summary>
        /// Gets or sets network inspection system enabled or not?
        /// </summary>
        [JsonProperty(PropertyName = "networkInspectionSystemEnabled")]
        public bool? NetworkInspectionSystemEnabled { get; set; }

        /// <summary>
        /// Gets or sets quick scan overdue or not?
        /// </summary>
        [JsonProperty(PropertyName = "quickScanOverdue")]
        public bool? QuickScanOverdue { get; set; }

        /// <summary>
        /// Gets or sets full scan overdue or not?
        /// </summary>
        [JsonProperty(PropertyName = "fullScanOverdue")]
        public bool? FullScanOverdue { get; set; }

        /// <summary>
        /// Gets or sets signature out of date or not?
        /// </summary>
        [JsonProperty(PropertyName = "signatureUpdateOverdue")]
        public bool? SignatureUpdateOverdue { get; set; }

        /// <summary>
        /// Gets or sets reboot required or not?
        /// </summary>
        [JsonProperty(PropertyName = "rebootRequired")]
        public bool? RebootRequired { get; set; }

        /// <summary>
        /// Gets or sets full scan required or not?
        /// </summary>
        [JsonProperty(PropertyName = "fullScanRequired")]
        public bool? FullScanRequired { get; set; }

        /// <summary>
        /// Gets or sets current endpoint protection engine's version
        /// </summary>
        [JsonProperty(PropertyName = "engineVersion")]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Gets or sets current malware definitions version
        /// </summary>
        [JsonProperty(PropertyName = "signatureVersion")]
        public string SignatureVersion { get; set; }

        /// <summary>
        /// Gets or sets current anti malware version
        /// </summary>
        [JsonProperty(PropertyName = "antiMalwareVersion")]
        public string AntiMalwareVersion { get; set; }

        /// <summary>
        /// Gets or sets last quick scan datetime
        /// </summary>
        [JsonProperty(PropertyName = "lastQuickScanDateTime")]
        public System.DateTime? LastQuickScanDateTime { get; set; }

        /// <summary>
        /// Gets or sets last quick scan datetime
        /// </summary>
        [JsonProperty(PropertyName = "lastFullScanDateTime")]
        public System.DateTime? LastFullScanDateTime { get; set; }

        /// <summary>
        /// Gets or sets last quick scan signature version
        /// </summary>
        [JsonProperty(PropertyName = "lastQuickScanSignatureVersion")]
        public string LastQuickScanSignatureVersion { get; set; }

        /// <summary>
        /// Gets or sets last full scan signature version
        /// </summary>
        [JsonProperty(PropertyName = "lastFullScanSignatureVersion")]
        public string LastFullScanSignatureVersion { get; set; }

        /// <summary>
        /// Gets or sets last device health status reported time
        /// </summary>
        [JsonProperty(PropertyName = "lastReportedDateTime")]
        public System.DateTime? LastReportedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "detectedMalwareState")]
        public IList<MicrosoftgraphwindowsDeviceMalwareState> DetectedMalwareState { get; set; }

    }
}
