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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of Subnet and their operations over its parent. </summary>
    public partial class SubnetCollection : ArmCollection, IEnumerable<Subnet>, IAsyncEnumerable<Subnet>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubnetsRestOperations _subnetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubnetCollection"/> class for mocking. </summary>
        protected SubnetCollection()
        {
        }

        /// <summary> Initializes a new instance of SubnetCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubnetCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _subnetsRestClient = new SubnetsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualNetwork.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a subnet in the specified virtual network. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> or <paramref name="subnetParameters"/> is null. </exception>
        public virtual SubnetCreateOrUpdateOperation CreateOrUpdate(string subnetName, SubnetData subnetParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (subnetParameters == null)
            {
                throw new ArgumentNullException(nameof(subnetParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subnetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters, cancellationToken);
                var operation = new SubnetCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _subnetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters).Request, response);
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

        /// <summary> Creates or updates a subnet in the specified virtual network. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="subnetParameters"> Parameters supplied to the create or update subnet operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> or <paramref name="subnetParameters"/> is null. </exception>
        public async virtual Task<SubnetCreateOrUpdateOperation> CreateOrUpdateAsync(string subnetName, SubnetData subnetParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }
            if (subnetParameters == null)
            {
                throw new ArgumentNullException(nameof(subnetParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subnetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubnetCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _subnetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, subnetParameters).Request, response);
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

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<Subnet> Get(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.Get");
            scope.Start();
            try
            {
                var response = _subnetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Subnet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified subnet by virtual network and resource group. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public async virtual Task<Response<Subnet>> GetAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.Get");
            scope.Start();
            try
            {
                var response = await _subnetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Subnet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<Subnet> GetIfExists(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subnetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Subnet>(null, response.GetRawResponse())
                    : Response.FromValue(new Subnet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public async virtual Task<Response<Subnet>> GetIfExistsAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _subnetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, subnetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Subnet>(null, response.GetRawResponse())
                    : Response.FromValue(new Subnet(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(subnetName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string subnetName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (subnetName == null)
            {
                throw new ArgumentNullException(nameof(subnetName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubnetCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subnetName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all subnets in a virtual network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Subnet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Subnet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Subnet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subnetsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Subnet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subnetsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all subnets in a virtual network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Subnet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Subnet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Subnet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subnetsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Subnet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubnetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subnetsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Subnet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Subnet> IEnumerable<Subnet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Subnet> IAsyncEnumerable<Subnet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Subnet, SubnetData> Construct() { }
    }
}
