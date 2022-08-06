// <copyright file="GaugeConfigurationTests.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.UnitTests.Configurations
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Pulse.Configurations;

    /// <summary>
    /// Tests for gauge configuration.
    /// </summary>
    [TestClass]
    public class GaugeConfigurationTests
    {
        private GaugeConfiguration config;

        /// <summary>
        /// Initializes and sets up a gauge configuration.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            config = new GaugeConfiguration();
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
            CollectionAssert.AreEqual(immutableLabels, config.ImmutableLabels);
        }

        /// <summary>
        /// Tests that we are able to get and set mutable label names.
        /// </summary>
        [TestMethod]
        public void TestMutableLabelNamesGetAndSet()
        {
            config.MutableLabelNames.Should().BeNull();
            var mutableLabelNames = new string[] { "foo", "bar" };
            config.MutableLabelNames = mutableLabelNames;
            Assert.IsTrue(config.MutableLabelNames.SequenceEqual(mutableLabelNames));
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
