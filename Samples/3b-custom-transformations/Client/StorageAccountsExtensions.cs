// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageAccounts.
    /// </summary>
    public static partial class StorageAccountsExtensions
    {
            /// <summary>
            /// Asynchronously creates a new storage account with the specified parameters.
            /// Existing accounts cannot be updated with this API and should instead use
            /// the Update Storage Account API. If an account is already created and
            /// subsequent PUT request is issued with exact same set of properties, then
            /// HTTP 200 would be returned.  Make sure you add that extra cowbell.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            public static StorageAccount BeginCreate(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified parameters.
            /// Existing accounts cannot be updated with this API and should instead use
            /// the Update Storage Account API. If an account is already created and
            /// subsequent PUT request is issued with exact same set of properties, then
            /// HTTP 200 would be returned.  Make sure you add that extra cowbell.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccount> BeginCreateAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
