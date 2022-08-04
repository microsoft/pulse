// <copyright file="ITimer.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.Interfaces
{
    using System;

    /// <summary>
    /// Interface for allowing metrics to use a timer.
    /// </summary>
    public interface ITimer : IDisposable
    {
    }
}
