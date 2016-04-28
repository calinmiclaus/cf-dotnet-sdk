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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class DomainsDeprecatedTest
    {


        [TestMethod]
        public void TestCreateDomainOwnedByGivenOrganizationDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""7ffeae87-4936-412e-8823-8c85dbc4a976"",
    ""url"": ""/v2/domains/2029e356-91aa-4225-8bcb-84ee0ab83ce4"",
    ""created_at"": ""2016-05-05T14:15:21Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""7ffeae87-4936-412e-8823-8c85dbc4a976"",
    ""shared_organizations"": [

    ],
    ""owning_organization_url"": ""/v2/organizations/3b5fe7f2-d9b9-4e7f-89b4-8e1ec29d0d5c"",
    ""spaces_url"": ""/v2/domains/2029e356-91aa-4225-8bcb-84ee0ab83ce4/spaces""
  }
}";

            CreateDomainOwnedByGivenOrganizationDeprecatedResponse obj = Utilities.DeserializeJson<CreateDomainOwnedByGivenOrganizationDeprecatedResponse>(json);

            Assert.AreEqual("7ffeae87-4936-412e-8823-8c85dbc4a976", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/2029e356-91aa-4225-8bcb-84ee0ab83ce4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:21Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("7ffeae87-4936-412e-8823-8c85dbc4a976", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/3b5fe7f2-d9b9-4e7f-89b4-8e1ec29d0d5c", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/domains/2029e356-91aa-4225-8bcb-84ee0ab83ce4/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSpacesForDomainDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""4b6f3692-fcb2-449b-92eb-2f67df96722b"",
        ""url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee"",
        ""created_at"": ""2016-05-05T14:15:20Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1820"",
        ""organization_guid"": ""4b6f3692-fcb2-449b-92eb-2f67df96722b"",
        ""space_quota_definition_guid"": null,
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/d6f5f4f8-0591-4737-8359-c4ed174fe74e"",
        ""developers_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/developers"",
        ""managers_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/managers"",
        ""auditors_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/auditors"",
        ""apps_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/apps"",
        ""routes_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/routes"",
        ""domains_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/domains"",
        ""service_instances_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/service_instances"",
        ""app_events_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/app_events"",
        ""events_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/events"",
        ""security_groups_url"": ""/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForDomainDeprecatedResponse> page = Utilities.DeserializePage<ListAllSpacesForDomainDeprecatedResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("4b6f3692-fcb2-449b-92eb-2f67df96722b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:20Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1820", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("4b6f3692-fcb2-449b-92eb-2f67df96722b", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].AllowSsh), true);
            Assert.AreEqual("/v2/organizations/d6f5f4f8-0591-4737-8359-c4ed174fe74e", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/eb7d8ad2-2aa3-435b-a9e7-f3d792dbc7ee/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveDomainDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""520a07cb-2890-4fbd-b2b7-8eb120ad8eb8"",
    ""url"": ""/v2/domains/224c10b6-24e9-4b36-b71b-47afbedaf2bb"",
    ""created_at"": ""2016-05-05T14:15:21Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""domain-72.example.com"",
    ""router_group_guid"": null,
    ""router_group_type"": null
  }
}";

            RetrieveDomainDeprecatedResponse obj = Utilities.DeserializeJson<RetrieveDomainDeprecatedResponse>(json);

            Assert.AreEqual("520a07cb-2890-4fbd-b2b7-8eb120ad8eb8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/224c10b6-24e9-4b36-b71b-47afbedaf2bb", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:21Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-72.example.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupType), true);
        }

        [TestMethod]
        public void TestCreateSharedDomainDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""625b4215-866b-45b9-b030-20066f065688"",
    ""url"": ""/v2/domains/944b0002-5495-4a94-9421-6147ac202e30"",
    ""created_at"": ""2016-05-05T14:15:21Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com"",
    ""owning_organization_guid"": null,
    ""shared_organizations"": [

    ]
  }
}";

            CreateSharedDomainDeprecatedResponse obj = Utilities.DeserializeJson<CreateSharedDomainDeprecatedResponse>(json);

            Assert.AreEqual("625b4215-866b-45b9-b030-20066f065688", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/944b0002-5495-4a94-9421-6147ac202e30", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:21Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
        }

        [TestMethod]
        public void TestListAllDomainsDeprecatedResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""8acff84d-2bb7-477b-8545-90ab0e2faed1"",
        ""url"": ""/v2/domains/3114d0be-2abf-478b-80ae-2ab1fddcd759"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""8acff84d-2bb7-477b-8545-90ab0e2faed1"",
        ""url"": ""/v2/domains/0b64fd42-654d-4fac-aecc-6b2763848926"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""8acff84d-2bb7-477b-8545-90ab0e2faed1"",
        ""url"": ""/v2/domains/ebeecc4d-2f39-4796-99ca-ac26fce27c00"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""8acff84d-2bb7-477b-8545-90ab0e2faed1"",
        ""owning_organization_url"": ""/v2/organizations/7ce035b6-9b37-485f-8991-6f84a83f07b8"",
        ""spaces_url"": ""/v2/domains/ebeecc4d-2f39-4796-99ca-ac26fce27c00/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""8acff84d-2bb7-477b-8545-90ab0e2faed1"",
        ""url"": ""/v2/domains/810b6beb-5b34-47ec-9d5e-25a824820fe2"",
        ""created_at"": ""2016-05-05T14:15:21Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-69.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    }
  ]
}";

            PagedResponseCollection<ListAllDomainsDeprecatedResponse> page = Utilities.DeserializePage<ListAllDomainsDeprecatedResponse>(json, null);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("8acff84d-2bb7-477b-8545-90ab0e2faed1", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/3114d0be-2abf-478b-80ae-2ab1fddcd759", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].RouterGroupGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].RouterGroupType), true);
            Assert.AreEqual("8acff84d-2bb7-477b-8545-90ab0e2faed1", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/0b64fd42-654d-4fac-aecc-6b2763848926", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].RouterGroupGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].RouterGroupType), true);
            Assert.AreEqual("8acff84d-2bb7-477b-8545-90ab0e2faed1", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/ebeecc4d-2f39-4796-99ca-ac26fce27c00", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("8acff84d-2bb7-477b-8545-90ab0e2faed1", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/7ce035b6-9b37-485f-8991-6f84a83f07b8", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/domains/ebeecc4d-2f39-4796-99ca-ac26fce27c00/spaces", TestUtil.ToTestableString(page[2].SpacesUrl), true);
            Assert.AreEqual("8acff84d-2bb7-477b-8545-90ab0e2faed1", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/domains/810b6beb-5b34-47ec-9d5e-25a824820fe2", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:21Z", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-69.example.com", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].RouterGroupGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].RouterGroupType), true);
        }
    }
}
