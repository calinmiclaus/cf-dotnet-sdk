//------------------------------------------------------------------------------
// <auto-generated>
  //     This code was generated by a tool.
  //
  //     Changes to this file may cause incorrect behavior and will be lost if
  //     the code is regenerated.
  // </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupsEndpoint
{
        [TestMethod]
        public void UpdateSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4d7c990a-a8c8-4f7b-9816-f4157d622b7c"",
    ""url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745"",
    ""created_at"": ""2016-05-05T14:15:13Z"",
    ""updated_at"": ""2016-05-05T14:15:14Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateSecurityGroupRequest value = new UpdateSecurityGroupRequest();


                var obj = cfClient.SecurityGroups.UpdateSecurityGroup(guid, value).Result;


                Assert.AreEqual("4d7c990a-a8c8-4f7b-9816-f4157d622b7c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSpacesForSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""cca4e026-434f-4b33-a04a-4170ef0eef75"",
        ""url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc"",
        ""created_at"": ""2016-05-05T14:15:14Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1582"",
        ""organization_guid"": ""cca4e026-434f-4b33-a04a-4170ef0eef75"",
        ""space_quota_definition_guid"": null,
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/3f3eb734-04a1-4053-9a57-1e9f832a01d4"",
        ""developers_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/developers"",
        ""managers_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/managers"",
        ""auditors_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/auditors"",
        ""apps_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/apps"",
        ""routes_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/routes"",
        ""domains_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/domains"",
        ""service_instances_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/service_instances"",
        ""app_events_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/app_events"",
        ""events_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/events"",
        ""security_groups_url"": ""/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/security_groups""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.ListAllSpacesForSecurityGroup(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("cca4e026-434f-4b33-a04a-4170ef0eef75", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1582", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("cca4e026-434f-4b33-a04a-4170ef0eef75", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].AllowSsh), true);
                Assert.AreEqual("/v2/organizations/3f3eb734-04a1-4053-9a57-1e9f832a01d4", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/developers", TestUtil.ToTestableString(obj[0].DevelopersUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/spaces/321d7cd4-96ae-42c4-a6a7-8c21ab8796fc/security_groups", TestUtil.ToTestableString(obj[0].SecurityGroupsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSecurityGroupsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""e24a1925-48bd-45f0-bb79-cffe42f0c260"",
        ""url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy1"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""e24a1925-48bd-45f0-bb79-cffe42f0c260"",
        ""url"": ""/v2/security_groups/b34d524c-a851-4819-84c6-ba48ede4bfcf"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy2"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/b34d524c-a851-4819-84c6-ba48ede4bfcf/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""e24a1925-48bd-45f0-bb79-cffe42f0c260"",
        ""url"": ""/v2/security_groups/9f482a99-3fbe-4a75-8661-84a1b7cb4fd2"",
        ""created_at"": ""2016-05-05T14:15:14Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1597"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/9f482a99-3fbe-4a75-8661-84a1b7cb4fd2/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""e24a1925-48bd-45f0-bb79-cffe42f0c260"",
        ""url"": ""/v2/security_groups/3552ec5d-dc88-4b92-befb-694c95476aec"",
        ""created_at"": ""2016-05-05T14:15:14Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1598"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/3552ec5d-dc88-4b92-befb-694c95476aec/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""e24a1925-48bd-45f0-bb79-cffe42f0c260"",
        ""url"": ""/v2/security_groups/aa00f632-072b-42a2-b8e4-097ef5ddf7ea"",
        ""created_at"": ""2016-05-05T14:15:14Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1599"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/aa00f632-072b-42a2-b8e4-097ef5ddf7ea/spaces""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SecurityGroups.ListAllSecurityGroups().Result;

                Assert.AreEqual("5", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("e24a1925-48bd-45f0-bb79-cffe42f0c260", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);
                Assert.AreEqual("e24a1925-48bd-45f0-bb79-cffe42f0c260", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b34d524c-a851-4819-84c6-ba48ede4bfcf", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy2", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b34d524c-a851-4819-84c6-ba48ede4bfcf/spaces", TestUtil.ToTestableString(obj[1].SpacesUrl), true);
                Assert.AreEqual("e24a1925-48bd-45f0-bb79-cffe42f0c260", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/9f482a99-3fbe-4a75-8661-84a1b7cb4fd2", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1597", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/9f482a99-3fbe-4a75-8661-84a1b7cb4fd2/spaces", TestUtil.ToTestableString(obj[2].SpacesUrl), true);
                Assert.AreEqual("e24a1925-48bd-45f0-bb79-cffe42f0c260", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/3552ec5d-dc88-4b92-befb-694c95476aec", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1598", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[3].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[3].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/3552ec5d-dc88-4b92-befb-694c95476aec/spaces", TestUtil.ToTestableString(obj[3].SpacesUrl), true);
                Assert.AreEqual("e24a1925-48bd-45f0-bb79-cffe42f0c260", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/aa00f632-072b-42a2-b8e4-097ef5ddf7ea", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1599", TestUtil.ToTestableString(obj[4].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[4].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[4].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/aa00f632-072b-42a2-b8e4-097ef5ddf7ea/spaces", TestUtil.ToTestableString(obj[4].SpacesUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""bd78e8de-8fd2-4afd-a04c-e86b8f3dec46"",
    ""url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745"",
    ""created_at"": ""2016-05-05T14:15:13Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.RetrieveSecurityGroup(guid).Result;


                Assert.AreEqual("bd78e8de-8fd2-4afd-a04c-e86b8f3dec46", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void DeleteSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SecurityGroups.DeleteSecurityGroup(guid).Wait();

            }
        }

        [TestMethod]
        public void AssociateSpaceWithSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""7cee03eb-1f30-470f-a2e8-a69c64fe3c16"",
    ""url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745"",
    ""created_at"": ""2016-05-05T14:15:13Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.AssociateSpaceWithSecurityGroup(guid, space_guid).Result;


                Assert.AreEqual("7cee03eb-1f30-470f-a2e8-a69c64fe3c16", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b82e03ed-12f7-442e-81cc-d42ee198f745/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void RemoveSpaceFromSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                cfClient.SecurityGroups.RemoveSpaceFromSecurityGroup(guid, space_guid).Wait();

            }
        }

        [TestMethod]
        public void CreateSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""10944bc5-cb92-45a0-ae9d-d3f582b68bee"",
    ""url"": ""/v2/security_groups/66436f9a-e9c6-46fd-b44e-f6a10cb86f10"",
    ""created_at"": ""2016-05-05T14:15:14Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my_super_sec_group"",
    ""rules"": [
      {
        ""protocol"": ""icmp"",
        ""destination"": ""0.0.0.0/0"",
        ""type"": 0,
        ""code"": 1
      },
      {
        ""protocol"": ""tcp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""2048-3000"",
        ""log"": true
      },
      {
        ""protocol"": ""udp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""53, 5353""
      },
      {
        ""protocol"": ""all"",
        ""destination"": ""0.0.0.0/0""
      }
    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/66436f9a-e9c6-46fd-b44e-f6a10cb86f10/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSecurityGroupRequest value = new CreateSecurityGroupRequest();


                var obj = cfClient.SecurityGroups.CreateSecurityGroup(value).Result;


                Assert.AreEqual("10944bc5-cb92-45a0-ae9d-d3f582b68bee", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/66436f9a-e9c6-46fd-b44e-f6a10cb86f10", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my_super_sec_group", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/66436f9a-e9c6-46fd-b44e-f6a10cb86f10/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

    }
}