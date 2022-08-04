// <copyright file="IGauge.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    using System;

    /// <summary>
    /// Interface for Gauge metrics.
    /// </summary>
    public interface IGauge : IMetric
    {
        /// <summary>
        /// Gets gauge value.
        /// </summary>
        /// <returns><see cref="double"/>.</returns>
        public double Value { get; }

        /// <summary>
        /// Set this gauge to the supplied value.
        /// </summary>
        /// <param name="targetValue"><see cref="double"/>.</param>
        public void Set(double targetValue);

        /// <summary>
        /// Set label values on this gauge.
        /// </summary>
        /// <param name="labels">Label values.</param>
        /// <returns><see cref="IGauge"/>.</returns>
        public IGauge WithLabels(params string[] labels);

        /// <summary>
        /// Increment this gauge.
        /// </summary>
        /// <param name="value">Value to increment by.</param>
        public void Increment(double value = 1.0);

        /// <summary>
        /// Increment this gauge to the target value.
        /// </summary>
        /// <param name="targetValue">Value to increment to.</param>
        public void IncrementTo(double targetValue);

        /// <summary>
        /// Decrement this gauge by the supplied value.
        /// </summary>
        /// <param name="value">Value to decrement by.</param>
        public void Decrement(double value = 1.0);

        /// <summary>
        /// Decrement this gauge metric to the target value.
        /// </summary>
        /// <param name="targetValue">Value to decrement to.</param>
        public void DecrementTo(double targetValue);

        /// <summary>
        /// Tracks the number of in progress operations taking place and sets this gauge
        /// to that value.
        /// </summary>
        /// <returns><see cref="IDisposable"/>.</returns>
        /// <remarks>
        /// It is safe to track the sum of multiple concurrent in-progress operations with the same gauge.
        /// </remarks>
        public IDisposable TrackInProgress();
    }
}
