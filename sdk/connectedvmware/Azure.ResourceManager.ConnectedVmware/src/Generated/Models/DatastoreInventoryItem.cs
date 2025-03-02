// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> The datastore inventory item. </summary>
    internal partial class DatastoreInventoryItem : InventoryItemProperties
    {
        /// <summary> Initializes a new instance of DatastoreInventoryItem. </summary>
        internal DatastoreInventoryItem()
        {
            InventoryType = InventoryType.Datastore;
        }

        /// <summary> Gets or sets Maximum capacity of this datastore, in GBs. </summary>
        public long? CapacityGB { get; }
        /// <summary> Gets or sets Available space of this datastore, in GBs. </summary>
        public long? FreeSpaceGB { get; }
    }
}
