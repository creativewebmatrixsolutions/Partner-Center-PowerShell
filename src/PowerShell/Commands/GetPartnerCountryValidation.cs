﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Management.Automation;
    using Models.CountryValidationRules;

    [Cmdlet(VerbsCommon.Get, "PartnerCountryValidation"), OutputType(typeof(PSCountryValidationRules))]
    public class GetPartnerCountryValidation : PartnerCmdlet
    {
        /// <summary>
        /// Gets or sets the country code in ISO2 format.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The country code in ISO2 format.")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            WriteObject(new PSCountryValidationRules(Partner.CountryValidationRules.ByCountry(CountryCode).GetAsync().ConfigureAwait(false).GetAwaiter().GetResult()));
        }
    }
}