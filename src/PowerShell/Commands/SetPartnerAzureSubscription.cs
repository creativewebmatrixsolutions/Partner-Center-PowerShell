﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Management.Automation;
    using System.Text.RegularExpressions;
    using Azure.Management.Profiles.Subscription;
    using Azure.Management.Profiles.Subscription.Models;
    using Models.Authentication;

    [Cmdlet(VerbsCommon.Set, "PartnerAzureSubscription")]
    [OutputType(typeof(string))]
    public class SetPartnerAzureSubscription : PartnerAsyncCmdlet
    {
        /// <summary>
        /// Gets or sets the subscription identifier.
        /// </summary>
        [Parameter(HelpMessage = "The identifier of the customer.", Mandatory = true)]
        [ValidatePattern(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", Options = RegexOptions.Compiled | RegexOptions.IgnoreCase)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the subscription identifier.
        /// </summary>
        [Parameter(HelpMessage = "The identifier of the subscription.", Mandatory = true)]
        [ValidatePattern(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", Options = RegexOptions.Compiled | RegexOptions.IgnoreCase)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the subscription name.
        /// </summary>
        [Parameter(HelpMessage = "The display name for the subscription.", Mandatory = true)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            Scheduler.RunTask(async () =>
            {
                ISubscriptionClient client = await PartnerSession.Instance.ClientFactory.CreateServiceClientAsync<SubscriptionClient>(
                    new[] { $"{PartnerSession.Instance.Context.Environment.AzureEndpoint}//user_impersonation" },
                    CustomerId);

                RenamedSubscriptionId value = client.Subscriptions.RenameAsync(
                    SubscriptionId,
                    new SubscriptionName
                    {
                        SubscriptionNameProperty = SubscriptionName
                    },
                    CancellationToken).ConfigureAwait(false).GetAwaiter().GetResult();

                WriteObject(value.Value);
            }, true);
        }
    }
}