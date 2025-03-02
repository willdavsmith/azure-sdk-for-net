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
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of Advisor and their operations over its parent. </summary>
    public partial class ServerAdvisorCollection : ArmCollection, IEnumerable<ServerAdvisor>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerAdvisorsRestOperations _serverAdvisorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerAdvisorCollection"/> class for mocking. </summary>
        protected ServerAdvisorCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerAdvisorCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerAdvisorCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverAdvisorsRestClient = new ServerAdvisorsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlServer.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAdvisors_Get
        /// <summary> Gets a server advisor. </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<ServerAdvisor> Get(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = _serverAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAdvisor(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAdvisors_Get
        /// <summary> Gets a server advisor. </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public async virtual Task<Response<ServerAdvisor>> GetAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerAdvisor(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<ServerAdvisor> GetIfExists(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerAdvisor>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerAdvisor(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public async virtual Task<Response<ServerAdvisor>> GetIfExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerAdvisor>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerAdvisor(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(advisorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="advisorName"> The name of the Server Advisor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="advisorName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string advisorName, CancellationToken cancellationToken = default)
        {
            if (advisorName == null)
            {
                throw new ArgumentNullException(nameof(advisorName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(advisorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAdvisors_ListByServer
        /// <summary> Gets a list of server advisors. </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ServerAdvisor>> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.GetAll");
            scope.Start();
            try
            {
                var response = _serverAdvisorsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                return Response.FromValue(response.Value.Select(value => new ServerAdvisor(Parent, value)).ToArray() as IReadOnlyList<ServerAdvisor>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerAdvisors_ListByServer
        /// <summary> Gets a list of server advisors. </summary>
        /// <param name="expand"> The child resources to include in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<ServerAdvisor>>> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerAdvisorCollection.GetAll");
            scope.Start();
            try
            {
                var response = await _serverAdvisorsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Select(value => new ServerAdvisor(Parent, value)).ToArray() as IReadOnlyList<ServerAdvisor>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerAdvisor> IEnumerable<ServerAdvisor>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerAdvisor, AdvisorData> Construct() { }
    }
}
