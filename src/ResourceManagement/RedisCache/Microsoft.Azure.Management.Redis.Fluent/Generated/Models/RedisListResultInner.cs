// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The response of list Redis operation.
    /// </summary>
    public partial class RedisListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the RedisListResultInner class.
        /// </summary>
        public RedisListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the RedisListResultInner class.
        /// </summary>
        /// <param name="value">List of Redis cache instances.</param>
        /// <param name="nextLink">Link for next set of locations.</param>
        public RedisListResultInner(System.Collections.Generic.IList<RedisResourceInner> value = default(System.Collections.Generic.IList<RedisResourceInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets list of Redis cache instances.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<RedisResourceInner> Value { get; set; }

        /// <summary>
        /// Gets or sets link for next set of locations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}