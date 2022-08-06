﻿// <copyright file="HistogramConfiguration.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Configurations
{
    #nullable enable

    /// <summary>
    /// Defines a histogram's configuration.
    /// </summary>
    public class HistogramConfiguration : MetricConfiguration
    {
        /// <summary>
        /// Gets or sets buckets for the histogram.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1011:Closing square brackets should be spaced correctly", Justification = "Null type")]
        public double[]? Buckets { get; set; }
    }
}
