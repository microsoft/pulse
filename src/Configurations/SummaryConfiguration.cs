// <copyright file="SummaryConfiguration.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Configurations
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a summary's configuration.
    /// </summary>
    public class SummaryConfiguration : MetricConfiguration
    {
        /// <summary>
        /// Default age buckets.
        /// </summary>
        public static readonly int DefaultAgeBuckets = 5;

        /// <summary>
        /// Default buffer size.
        /// </summary>
        public static readonly int DefaultBufferSize = 500;

        /// <summary>
        /// Default max age.
        /// </summary>
        public static readonly TimeSpan DefaultMaxAge = TimeSpan.FromMinutes(10);

        /// <summary>
        /// Gets or sets the number of buckets which control measurement expiration.
        /// </summary>
        /// <remarks>By default, we set 5 age buckets.</remarks>
        public int AgeBuckets { get; set; } = 5;

        /// <summary>
        /// Gets or sets the buffer size limit.
        /// </summary>
        /// <remarks>By default, buffer size is set to 500. You should only set this to increments of 500.</remarks>
        public int BufferSize { get; set; } = 500;

        /// <summary>
        /// Gets or sets the age over which to summarize.
        /// </summary>
        /// <remarks>By default, we set the age to 10 minutes.</remarks>
        public TimeSpan MaxAge { get; set; } = TimeSpan.FromMinutes(10);

        /// <summary>
        /// Gets or sets a pairs of quantile (group of values) epsilon (defined margin of error) values.
        /// </summary>
        public IReadOnlyList<(double Quantile, double Epsilon)> Objectives { get; set; } = null;
    }
}
