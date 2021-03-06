﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Omnicx.API.SDK.Recomendation.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ModelDiversityMetrics
    {
        /// <summary>
        /// Initializes a new instance of the ModelDiversityMetrics class.
        /// </summary>
        public ModelDiversityMetrics() { }

        /// <summary>
        /// Initializes a new instance of the ModelDiversityMetrics class.
        /// </summary>
        public ModelDiversityMetrics(IList<PercentileBucket> percentileBuckets = default(IList<PercentileBucket>), int? totalItemsRecommended = default(int?), int? uniqueItemsRecommended = default(int?), int? uniqueItemsInTrainSet = default(int?))
        {
            PercentileBuckets = percentileBuckets;
            TotalItemsRecommended = totalItemsRecommended;
            UniqueItemsRecommended = uniqueItemsRecommended;
            UniqueItemsInTrainSet = uniqueItemsInTrainSet;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "percentileBuckets")]
        public IList<PercentileBucket> PercentileBuckets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalItemsRecommended")]
        public int? TotalItemsRecommended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniqueItemsRecommended")]
        public int? UniqueItemsRecommended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniqueItemsInTrainSet")]
        public int? UniqueItemsInTrainSet { get; set; }

    }
}
