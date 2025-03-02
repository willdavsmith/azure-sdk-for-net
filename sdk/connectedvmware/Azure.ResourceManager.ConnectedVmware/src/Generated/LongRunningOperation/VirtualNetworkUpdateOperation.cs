// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ConnectedVmware;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> API to update certain properties of the virtual network resource. </summary>
    public partial class VirtualNetworkUpdateOperation : Operation<VirtualNetwork>
    {
        private readonly OperationOrResponseInternals<VirtualNetwork> _operation;

        /// <summary> Initializes a new instance of VirtualNetworkUpdateOperation for mocking. </summary>
        protected VirtualNetworkUpdateOperation()
        {
        }

        internal VirtualNetworkUpdateOperation(ArmResource operationsBase, Response<VirtualNetworkData> response)
        {
            _operation = new OperationOrResponseInternals<VirtualNetwork>(Response.FromValue(new VirtualNetwork(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualNetwork Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetwork>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetwork>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
