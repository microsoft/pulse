// <copyright file="IMetric.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    /// <summary>
    /// Interface for all metrics.
    /// </summary>
    public interface IMetric
    {
        /// <summary>
        /// Create a new ITimer for this metric.
        /// </summary>
        /// <returns><see cref="ITimer"/>.</returns>
        public ITimer NewTimer();
    }
}
