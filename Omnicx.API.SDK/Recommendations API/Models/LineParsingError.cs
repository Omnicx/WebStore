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

    /// <summary>
    /// A line parsing error information
    /// </summary>
    public partial class LineParsingError
    {
        /// <summary>
        /// Initializes a new instance of the LineParsingError class.
        /// </summary>
        public LineParsingError() { }

        /// <summary>
        /// Initializes a new instance of the LineParsingError class.
        /// </summary>
        public LineParsingError(int? count = default(int?), Error? error = default(Error?), ParsingErrorSample sample = default(ParsingErrorSample))
        {
            Count = count;
            Error = error;
            Sample = sample;
        }

        /// <summary>
        /// Gets the error count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets the parsing error reason. Possible values include:
        /// 'MalformedLine', 'MissingFields', 'BadTimestampFormat',
        /// 'BadWeightFormat', 'MalformedCatalogItemFeature',
        /// 'ItemIdTooLong', 'IllegalCharactersInItemId', 'UserIdTooLong',
        /// 'IllegalCharactersInUserId', 'UnknownItemId', 'DuplicateItemId'
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error? Error { get; set; }

        /// <summary>
        /// Gets the parsing error sample
        /// </summary>
        [JsonProperty(PropertyName = "sample")]
        public ParsingErrorSample Sample { get; set; }

    }
}
