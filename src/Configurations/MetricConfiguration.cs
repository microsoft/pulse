// <copyright file="MetricConfiguration.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Configurations
{
    #nullable enable

    using System.Collections.Generic;

    /// <summary>
    /// Defines the base properties of a metric's configuration.
    /// </summary>
    public class MetricConfiguration
    {
        /// <summary>
        /// Gets or sets immutable labels for the metric.
        /// </summary>
        public Dictionary<string, string>? ImmutableLabels { get; set; }

        /// <summary>
        /// Gets or sets mutable label names for the metric.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1011:Closing square brackets should be spaced correctly", Justification = "Null type")]
        public string[]? MutableLabelNames { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the metric should be emitted
        /// upon creation or not.
        /// </summary>
        /// <remarks>By default, we publish on creation.</remarks>
        public bool PublishOnCreation { get; set; } = true;
    }
}
