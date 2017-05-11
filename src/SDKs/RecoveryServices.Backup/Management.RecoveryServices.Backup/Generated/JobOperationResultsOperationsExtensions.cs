// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobOperationResultsOperations.
    /// </summary>
    public static partial class JobOperationResultsOperationsExtensions
    {
            /// <summary>
            /// Fetches the result of any operation.
            /// the operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='jobName'>
            /// Job name whose operation result has to be fetched.
            /// </param>
            /// <param name='operationId'>
            /// OperationID which represents the operation whose result has to be fetched.
            /// </param>
            public static void Get(this IJobOperationResultsOperations operations, string vaultName, string resourceGroupName, string jobName, string operationId)
            {
                operations.GetAsync(vaultName, resourceGroupName, jobName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches the result of any operation.
            /// the operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='jobName'>
            /// Job name whose operation result has to be fetched.
            /// </param>
            /// <param name='operationId'>
            /// OperationID which represents the operation whose result has to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAsync(this IJobOperationResultsOperations operations, string vaultName, string resourceGroupName, string jobName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, jobName, operationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}