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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of JobVersion and their operations over its parent. </summary>
    public partial class JobVersionCollection : ArmCollection, IEnumerable<JobVersion>, IAsyncEnumerable<JobVersion>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobVersionsRestOperations _jobVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="JobVersionCollection"/> class for mocking. </summary>
        protected JobVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of JobVersionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal JobVersionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _jobVersionsRestClient = new JobVersionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlJob.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// OperationId: JobVersions_Get
        /// <summary> Gets a job version. </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobVersion> Get(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _jobVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new JobVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions/{jobVersion}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// OperationId: JobVersions_Get
        /// <summary> Gets a job version. </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<JobVersion>> GetAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new JobVersion(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobVersion> GetIfExists(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<JobVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new JobVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<JobVersion>> GetIfExistsAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _jobVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, jobVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<JobVersion>(null, response.GetRawResponse())
                    : Response.FromValue(new JobVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(jobVersion, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jobVersion"> The version of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(int jobVersion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(jobVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// OperationId: JobVersions_ListByJob
        /// <summary> Gets all versions of a job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JobVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JobVersion> GetAll(CancellationToken cancellationToken = default)
        {
            Page<JobVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobVersionsRestClient.ListByJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobVersionsRestClient.ListByJobNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new JobVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}/versions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/jobAgents/{jobAgentName}/jobs/{jobName}
        /// OperationId: JobVersions_ListByJob
        /// <summary> Gets all versions of a job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JobVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JobVersion> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<JobVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobVersionsRestClient.ListByJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobVersionsRestClient.ListByJobNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new JobVersion(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<JobVersion> IEnumerable<JobVersion>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<JobVersion> IAsyncEnumerable<JobVersion>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, JobVersion, JobVersionData> Construct() { }
    }
}
