﻿using Newtonsoft.Json;

namespace Kentico.Kontent.Management.Models.Collections.Patch
{
    /// <summary>
    /// Represents the operation on collections.
    /// More info: https://docs.kontent.ai/reference/management-api-v2#operation/list-collections
    /// </summary>
    public abstract class CollectionOperationBaseModel
    {
        /// <summary>
        /// Gets specification of the operation to perform.
        /// More info: https://docs.kontent.ai/reference/management-api-v2#operation/list-collections
        /// </summary>
        [JsonProperty("op", Required = Required.Always)]
        public abstract string Op { get; }
    }
}
