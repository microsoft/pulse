// <copyright file="SummaryConfigurationTests.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>

namespace Pulse.UnitTests.Configurations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Pulse.Configurations;

    /// <summary>
    /// Tests for summary configuration.
    /// </summary>
    [TestClass]
    public class SummaryConfigurationTests
    {
        private SummaryConfiguration config;

        /// <summary>
        /// Initializes and sets up a summary configuration.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            config = new SummaryConfiguration();
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
        /// Tests that we are able to get and set variable label names.
        /// </summary>
        [TestMethod]
        public void TestVariableLabelNamesGetAndSet()
        {
            config.VariableLabelNames.Should().BeNull();
            var variableLabelNames = new string[] { "foo", "bar" };
            config.VariableLabelNames = variableLabelNames;
            Assert.IsTrue(config.VariableLabelNames.SequenceEqual(variableLabelNames));
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

        /// <summary>
        /// Tests that we are able to get and set age buckets.
        /// </summary>
        [TestMethod]
        public void TestAgeBucketsGetAndSet()
        {
            config.AgeBuckets.Should().BeNull();
            uint ageBuckets = 2;
            config.AgeBuckets = ageBuckets;
            config.AgeBuckets.Should().Be(ageBuckets);
        }

        /// <summary>
        /// Tests that we are able to get and set buffer size.
        /// </summary>
        [TestMethod]
        public void TestBufferSizeGetAndSet()
        {
            config.BufferSize.Should().BeNull();
            uint bufferSize = 500;
            config.BufferSize = bufferSize;
            config.BufferSize.Should().Be(bufferSize);
        }

        /// <summary>
        /// Tests that we are able to get and set max age.
        /// </summary>
        [TestMethod]
        public void TestMaxAgeGetAndSet()
        {
            config.MaxAge.Should().BeNull();
            var maxAge = TimeSpan.FromMinutes(60);
            config.MaxAge = maxAge;
            config.MaxAge.Should().Be(maxAge);
        }

        /// <summary>
        /// Tests that we are able to get and set objectives.
        /// </summary>
        [TestMethod]
        public void TestObjectivesGetAndSet()
        {
            config.Objectives.Should().BeNull();
            IReadOnlyList<(double, double)> objectives = new[] { (1.0, 3.0), (3.0, 4.0) };
            config.Objectives = objectives;
            Assert.IsTrue(config.Objectives.SequenceEqual(objectives));
        }
    }
}