// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SnapshotsOperations.
    /// </summary>
    public static partial class SnapshotsOperationsExtensions
    {
        /// <summary>
        /// Creates or updates a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='snapshot'>
        /// Snapshot object supplied in the body of the Put disk operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SnapshotInner> CreateOrUpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotInner snapshot, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Updates (patches) a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='snapshot'>
        /// Snapshot object supplied in the body of the Patch snapshot operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SnapshotInner> UpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotUpdate snapshot, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets information about a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SnapshotInner> GetAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Lists snapshots under a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<SnapshotInner>> ListByResourceGroupAsync(this ISnapshotsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Lists snapshots under a subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<SnapshotInner>> ListAsync(this ISnapshotsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Grants access to a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='grantAccessData'>
        /// Access data object supplied in the body of the get snapshot access
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<AccessUriInner> GrantAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, GrantAccessData grantAccessData, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GrantAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, grantAccessData, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Revokes access to a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task RevokeAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.RevokeAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Creates or updates a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='snapshot'>
        /// Snapshot object supplied in the body of the Put disk operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SnapshotInner> BeginCreateOrUpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotInner snapshot, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Updates (patches) a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='snapshot'>
        /// Snapshot object supplied in the body of the Patch snapshot operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SnapshotInner> BeginUpdateAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, SnapshotUpdate snapshot, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, snapshotName, snapshot, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task BeginDeleteAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Grants access to a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='grantAccessData'>
        /// Access data object supplied in the body of the get snapshot access
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<AccessUriInner> BeginGrantAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, GrantAccessData grantAccessData, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginGrantAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, grantAccessData, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Revokes access to a snapshot.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='snapshotName'>
        /// The name of the snapshot that is being created. The name can't be changed
        /// after the snapshot is created. Supported characters for the name are a-z,
        /// A-Z, 0-9 and _. The max name length is 80 characters.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task BeginRevokeAccessAsync(this ISnapshotsOperations operations, string resourceGroupName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.BeginRevokeAccessWithHttpMessagesAsync(resourceGroupName, snapshotName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Lists snapshots under a resource group.
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
        public static async Task<IPage<SnapshotInner>> ListByResourceGroupNextAsync(this ISnapshotsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Lists snapshots under a subscription.
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
        public static async Task<IPage<SnapshotInner>> ListNextAsync(this ISnapshotsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
