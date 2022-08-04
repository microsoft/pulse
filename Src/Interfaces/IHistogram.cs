// <copyright file="IHistogram.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    /// <summary>
    /// Interface for Histogram metrics.
    /// </summary>
    public interface IHistogram : IMetric
    {
        /// <summary>
        /// Gets the sum of all observed events.
        /// </summary>
        public double Sum { get; }

        /// <summary>
        /// Gets the count of all observed events.
        /// </summary>
        public long Count { get; }

        /// <summary>
        /// Set label values on this histogram.
        /// </summary>
        /// <param name="labels">Label values.</param>
        /// <returns><see cref="IHistogram"/>.</returns>
        public IHistogram WithLabels(params string[] labels);

        /// <summary>
        /// Observes a single event with the given value.
        /// </summary>
        /// <param name="value">Measured value.</param>
        public void Observe(double value);

        /// <summary>
        /// Observe multiple events with a given value.
        /// Intended to support high frequency or batch processing use cases utilizing pre-aggregation.
        /// </summary>
        /// <param name="val">Measured value.</param>
        /// <param name="count">Number of observations with this value.</param>
        public void Observe(double val, long count);
    }
}
