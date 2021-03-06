// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BatchAccountOperations.
    /// </summary>
    public static partial class BatchAccountOperationsExtensions
    {
            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated with
            /// the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            public static BatchAccount Create(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated with
            /// the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccount> CreateAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of an existing Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account update.
            /// </param>
            public static BatchAccount Update(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of an existing Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccount> UpdateAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            public static BatchAccountDeleteHeaders Delete(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                return operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccountDeleteHeaders> DeleteAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            public static BatchAccount Get(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccount> GetAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<BatchAccount> List(this IBatchAccountOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BatchAccount>> ListAsync(this IBatchAccountOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            public static IPage<BatchAccount> ListByResourceGroup(this IBatchAccountOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BatchAccount>> ListByResourceGroupAsync(this IBatchAccountOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Synchronizes access keys for the auto-storage account configured for the
            /// specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            public static void SynchronizeAutoStorageKeys(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                operations.SynchronizeAutoStorageKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Synchronizes access keys for the auto-storage account configured for the
            /// specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SynchronizeAutoStorageKeysAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.SynchronizeAutoStorageKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Regenerates the specified account key for the Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='keyName'>
            /// The type of account key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            public static BatchAccountKeys RegenerateKey(this IBatchAccountOperations operations, string resourceGroupName, string accountName, AccountKeyType keyName)
            {
                return operations.RegenerateKeyAsync(resourceGroupName, accountName, keyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the specified account key for the Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='keyName'>
            /// The type of account key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccountKeys> RegenerateKeyAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, AccountKeyType keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the account keys for the specified Batch account.
            /// </summary>
            /// <remarks>
            /// This operation applies only to Batch accounts created with a
            /// poolAllocationMode of 'BatchService'. If the Batch account was created with
            /// a poolAllocationMode of 'UserSubscription', clients cannot use access to
            /// keys to authenticate, and must use Azure Active Directory instead. In this
            /// case, getting the keys will fail.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            public static BatchAccountKeys GetKeys(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the account keys for the specified Batch account.
            /// </summary>
            /// <remarks>
            /// This operation applies only to Batch accounts created with a
            /// poolAllocationMode of 'BatchService'. If the Batch account was created with
            /// a poolAllocationMode of 'UserSubscription', clients cannot use access to
            /// keys to authenticate, and must use Azure Active Directory instead. In this
            /// case, getting the keys will fail.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccountKeys> GetKeysAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated with
            /// the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            public static BatchAccount BeginCreate(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Batch account with the specified parameters. Existing
            /// accounts cannot be updated with this API and should instead be updated with
            /// the Update Batch Account API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// A name for the Batch account which must be unique within the region. Batch
            /// account names must be between 3 and 24 characters in length and must use
            /// only numbers and lowercase letters. This name is used as part of the DNS
            /// name that is used to access the Batch service in the region in which the
            /// account is created. For example:
            /// http://accountname.region.batch.azure.com/.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for account creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccount> BeginCreateAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, BatchAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            public static BatchAccountDeleteHeaders BeginDelete(this IBatchAccountOperations operations, string resourceGroupName, string accountName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Batch account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchAccountDeleteHeaders> BeginDeleteAsync(this IBatchAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BatchAccount> ListNext(this IBatchAccountOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BatchAccount>> ListNextAsync(this IBatchAccountOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BatchAccount> ListByResourceGroupNext(this IBatchAccountOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the Batch accounts associated with the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BatchAccount>> ListByResourceGroupNextAsync(this IBatchAccountOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

