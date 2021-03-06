﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using System.Collections.Generic;
using Xunit;

namespace Sql.Tests
{
    public class CapabilitiesScenarioTests
    {
        [Fact]
        public void TestGetCapabilities()
        {
            Dictionary<string, string> tags = new Dictionary<string, string>();
            string suiteName = this.GetType().FullName;

            SqlManagementTestUtilities.RunTest("Sql.Tests.CapabilitiesScenarioTests", "TestGetCapabilities", (resourceClient, sqlClient) =>
            {
                LocationCapabilities capabilities = sqlClient.Capabilities.ListByLocation(SqlManagementTestUtilities.DefaultLocation);

                Assert.NotNull(capabilities);

                foreach (ServerVersionCapability s in capabilities.SupportedServerVersions)
                {
                    Assert.NotNull(s.Name);
                    foreach (EditionCapability e in s.SupportedEditions)
                    {
                        Assert.NotNull(e.Name);
                        foreach (ServiceObjectiveCapability o in e.SupportedServiceLevelObjectives)
                        {
                            Assert.NotNull(o.Name);
                            Assert.NotNull(o.Unit);
                            foreach (MaxSizeCapability m in o.SupportedMaxSizes)
                            {
                                Assert.NotNull(m.Limit);
                                Assert.NotNull(m.Unit);
                            }
                        }
                    }
                }
            });
        }
    }
}
