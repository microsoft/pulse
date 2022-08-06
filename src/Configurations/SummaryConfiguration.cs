// <copyright file="SummaryConfiguration.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Configurations
{
    #nullable enable

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a summary's configuration.
    /// </summary>
    public class SummaryConfiguration : MetricConfiguration
    {
        /// <summary>
        /// Gets or sets the number of buckets which control measurement expiration.
        /// </summary>
        public uint? AgeBuckets { get; set; }

        /// <summary>
        /// Gets or sets the buffer size limit.
        /// </summary>
        public uint? BufferSize { get; set; }

        /// <summary>
        /// Gets or sets the age over which to summarize.
        /// </summary>
        public TimeSpan? MaxAge { get; set; }

        /// <summary>
        /// Gets or sets a pairs of quantile (group of values) epsilon (defined margin of error) values.
        /// </summary>
        public IReadOnlyList<(double Quantile, double Epsilon)>? Objectives { get; set; }
    }
}
