// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVmware.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVmware
{
    /// <summary> A class representing collection of HybridIdentityMetadata and their operations over its parent. </summary>
    public partial class HybridIdentityMetadataCollection : ArmCollection, IEnumerable<HybridIdentityMetadata>, IAsyncEnumerable<HybridIdentityMetadata>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HybridIdentityMetadataRestOperations _hybridIdentityMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridIdentityMetadataCollection"/> class for mocking. </summary>
        protected HybridIdentityMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of HybridIdentityMetadataCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal HybridIdentityMetadataCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _hybridIdentityMetadataRestClient = new HybridIdentityMetadataRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualMachine.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: HybridIdentityMetadata_Create
        /// <summary> Create Or Update HybridIdentityMetadata. </summary>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual HybridIdentityMetadataCreateOperation CreateOrUpdate(string metadataName, HybridIdentityMetadataData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, body, cancellationToken);
                var operation = new HybridIdentityMetadataCreateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: HybridIdentityMetadata_Create
        /// <summary> Create Or Update HybridIdentityMetadata. </summary>
        /// <param name="metadataName"> Name of the hybridIdentityMetadata. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public async virtual Task<HybridIdentityMetadataCreateOperation> CreateOrUpdateAsync(string metadataName, HybridIdentityMetadataData body = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, body, cancellationToken).ConfigureAwait(false);
                var operation = new HybridIdentityMetadataCreateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: HybridIdentityMetadata_Get
        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual Response<HybridIdentityMetadata> Get(string metadataName, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridIdentityMetadata(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: HybridIdentityMetadata_Get
        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public async virtual Task<Response<HybridIdentityMetadata>> GetAsync(string metadataName, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new HybridIdentityMetadata(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual Response<HybridIdentityMetadata> GetIfExists(string metadataName, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<HybridIdentityMetadata>(null, response.GetRawResponse())
                    : Response.FromValue(new HybridIdentityMetadata(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public async virtual Task<Response<HybridIdentityMetadata>> GetIfExistsAsync(string metadataName, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _hybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<HybridIdentityMetadata>(null, response.GetRawResponse())
                    : Response.FromValue(new HybridIdentityMetadata(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string metadataName, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(metadataName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="metadataName"> Name of the HybridIdentityMetadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metadataName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string metadataName, CancellationToken cancellationToken = default)
        {
            if (metadataName == null)
            {
                throw new ArgumentNullException(nameof(metadataName));
            }

            using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(metadataName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: HybridIdentityMetadata_ListByVm
        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridIdentityMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridIdentityMetadata> GetAll(CancellationToken cancellationToken = default)
        {
            Page<HybridIdentityMetadata> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridIdentityMetadataRestClient.ListByVm(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadata(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HybridIdentityMetadata> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _hybridIdentityMetadataRestClient.ListByVmNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadata(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}/hybridIdentityMetadata
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}
        /// OperationId: HybridIdentityMetadata_ListByVm
        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridIdentityMetadata" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridIdentityMetadata> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HybridIdentityMetadata>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridIdentityMetadataRestClient.ListByVmAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadata(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HybridIdentityMetadata>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("HybridIdentityMetadataCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _hybridIdentityMetadataRestClient.ListByVmNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HybridIdentityMetadata(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<HybridIdentityMetadata> IEnumerable<HybridIdentityMetadata>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridIdentityMetadata> IAsyncEnumerable<HybridIdentityMetadata>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, HybridIdentityMetadata, HybridIdentityMetadataData> Construct() { }
    }
}
