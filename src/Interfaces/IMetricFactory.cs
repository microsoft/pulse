// <copyright file="IMetricFactory.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    using System;
    using System.Collections.Generic;

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
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="ICounter"/>.</returns>
        public ICounter CreateCounter(string name, string desc, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="ICounter"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="staticLabels">Static labels and values.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="ICounter"/>.</returns>
        public ICounter CreateCounterWithStaticLabels(string name, string desc, Dictionary<string, string> staticLabels = null, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="IGauge"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="IGauge"/>.</returns>
        public IGauge CreateGauge(string name, string desc, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="IGauge"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="staticLabels">Static labels and values.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="IGauge"/>.</returns>
        public IGauge CreateGaugeWithStaticLabels(string name, string desc, Dictionary<string, string> staticLabels, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="IHistogram"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="buckets">Buckets.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="IHistogram"/>.</returns>
        public IHistogram CreateHistogram(string name, string desc, double[] buckets, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="IHistogram"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="buckets">Buckets.</param>
        /// <param name="staticLabels">Static labels and values.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="IHistogram"/>.</returns>
        public IHistogram CreateHistogramWithStaticLabels(string name, string desc, double[] buckets, Dictionary<string, string> staticLabels, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="ISummary"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="maxAge">Time span over which to calculate the summary.</param>
        /// <param name="ageBuckets">Number of buckets used to control measurement expiration.</param>
        /// <param name="bufferSize">Buffer size limit. Use multiples of 500 to avoid waste, as internal buffers use that size.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="ISummary"/>.</returns>
        public ISummary CreateSummary(string name, string desc, TimeSpan? maxAge = null, int? ageBuckets = null, int? bufferSize = null, params string[] labelNames);

        /// <summary>
        /// Create an implementation instance of <see cref="ISummary"/>.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="desc">Metric description.</param>
        /// <param name="staticLabels">Static labels and values.</param>
        /// <param name="maxAge">Time span over which to calculate the summary.</param>
        /// <param name="ageBuckets">Number of buckets used to control measurement expiration.</param>
        /// <param name="bufferSize">Buffer size limit. Use multiples of 500 to avoid waste, as internal buffers use that size.</param>
        /// <param name="labelNames">Label names.</param>
        /// <returns><see cref="ISummary"/>.</returns>
        public ISummary CreateSummaryWithStaticLabels(string name, string desc, Dictionary<string, string> staticLabels, TimeSpan? maxAge = null, int? ageBuckets = null, int? bufferSize = null, params string[] labelNames);
    }
}
