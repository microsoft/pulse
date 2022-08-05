// <copyright file="CounterConfigurationTests.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.UnitTests.Configurations
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Pulse.Configurations;

    /// <summary>
    /// Tests for counter configuration.
    /// </summary>
    [TestClass]
    public class CounterConfigurationTests
    {
        private CounterConfiguration config;

        /// <summary>
        /// Initializes and sets up a counter configuration.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            config = new CounterConfiguration();
        }

        /// <summary>
        /// Tests that we are able to get and set immutable labels.
        /// </summary>
        [TestMethod]
        public void TestImmutableLabelsGetAndSet()
        {
            config.ImmutableLabels.Should().BeNull();
            var immutableLabels = new Dictionary<string, string>() { { "foo", "bar" } };
            config.ImmutableLabels = immutableLabels;
            config.ImmutableLabels.Should().BeEquivalentTo(immutableLabels);
        }

        /// <summary>
        /// Tests that we are able to get and set variable label names.
        /// </summary>
        [TestMethod]
        public void TestVariableLabelNamesGetAndSet()
        {
            config.VariableLabelNames.Should().BeNull();
            var variableLabelNames = new string[] { "foo", "bar" };
            config.VariableLabelNames = variableLabelNames;
            config.VariableLabelNames.Should().BeEquivalentTo(variableLabelNames);
        }

        /// <summary>
        /// Tests that we are able to get and set publish on creation.
        /// </summary>
        [TestMethod]
        public void TestPublishOnCreationGetAndSet()
        {
            config.PublishOnCreation.Should().BeTrue();
            var publishOnCreation = false;
            config.PublishOnCreation = publishOnCreation;
            config.PublishOnCreation.Should().Be(publishOnCreation);
        }
    }
}