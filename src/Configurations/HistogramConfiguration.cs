// <copyright file="HistogramConfiguration.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Configurations
{
    /// <summary>
    /// Defines a histogram's configuration.
    /// </summary>
    public class HistogramConfiguration : MetricConfiguration
    {
        /// <summary>
        /// Default buckets.
        /// </summary>
        public static readonly double[] DefaultBuckets = { .005, .01, .025, .05, .075, .1, .25, .5, .75, 1, 2.5, 5, 7.5, 10 };

        /// <summary>
        /// Gets or sets buckets for the histogram.
        /// </summary>
        /// <remarks>By default, we set the buckets to { .005, .01, .025, .05, .075, .1, .25, .5, .75, 1, 2.5, 5, 7.5, 10 }.</remarks>
        public double[] Buckets { get; set; } = DefaultBuckets;
    }
}
