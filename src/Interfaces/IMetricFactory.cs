// <copyright file="IMetricFactory.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    using Pulse.Configurations;

    /// <summary>
    /// Factory interface for creating new metric instances.
    /// </summary>
    public interface IMetricFactory
    {
        /// <summary>
        /// Create an implementation instance of <see cref="ICounter"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="config"><see cref="CounterConfiguration"/>.</param>
        /// <returns><see cref="ICounter"/>.</returns>
        public ICounter CreateCounter(string name, string desc, CounterConfiguration config = null);

        /// <summary>
        /// Create an implementation instance of <see cref="IGauge"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="config"><see cref="GaugeConfiguration"/>.</param>
        /// <returns><see cref="IGauge"/>.</returns>
        public IGauge CreateGauge(string name, string desc, GaugeConfiguration config = null);

        /// <summary>
        /// Create an implementation instance of <see cref="IHistogram"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="config"><see cref="HistogramConfiguration"/>.</param>
        /// <returns><see cref="IHistogram"/>.</returns>
        public IHistogram CreateHistogram(string name, string desc, HistogramConfiguration config = null);

        /// <summary>
        /// Create an implementation instance of <see cref="ISummary"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="config"><see cref="SummaryConfiguration"/>.</param>
        /// <returns><see cref="ISummary"/>.</returns>
        public ISummary CreateSummary(string name, string desc, SummaryConfiguration config = null);
    }
}
