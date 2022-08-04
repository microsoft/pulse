// <copyright file="ISummary.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    /// <summary>
    /// Interface for Summary metrics.
    /// </summary>
    public interface ISummary : IMetric
    {
        /// <summary>
        /// Observes a single event with the given value.
        /// </summary>
        /// <param name="value">Measured value.</param>
        public void Observe(double value);

        /// <summary>
        /// Set user-defined lable values.
        /// </summary>
        /// <param name="labels">Label values.</param>
        /// <returns><see cref="ISummary"/>.</returns>
        public ISummary WithLabels(params string[] labels);
    }
}
