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
    public class PrivateDomainsTest
    {


        [TestMethod]
        public void TestRetrievePrivateDomainResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""3e6bc6d3-5df5-4b6f-9377-1f68f7979beb"",
    ""url"": ""/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59"",
    ""created_at"": ""2016-05-05T14:14:47Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""3e6bc6d3-5df5-4b6f-9377-1f68f7979beb"",
    ""owning_organization_url"": ""/v2/organizations/69275b67-e9ee-4542-839f-228a1c7c9827"",
    ""shared_organizations_url"": ""/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59/shared_organizations""
  }
}";

            RetrievePrivateDomainResponse obj = Utilities.DeserializeJson<RetrievePrivateDomainResponse>(json);

            Assert.AreEqual("3e6bc6d3-5df5-4b6f-9377-1f68f7979beb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:47Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("3e6bc6d3-5df5-4b6f-9377-1f68f7979beb", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/69275b67-e9ee-4542-839f-228a1c7c9827", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestFilterPrivateDomainsByNameResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d17494ef-23b8-43ba-a056-b12a5906d91a"",
        ""url"": ""/v2/private_domains/1780bb83-34c0-4bfb-9843-2a701b863517"",
        ""created_at"": ""2016-05-05T14:15:00Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""d17494ef-23b8-43ba-a056-b12a5906d91a"",
        ""owning_organization_url"": ""/v2/organizations/c38f327c-95e8-4e15-b08b-bc62b963be6f"",
        ""shared_organizations_url"": ""/v2/private_domains/1780bb83-34c0-4bfb-9843-2a701b863517/shared_organizations""
      }
    }
  ]
}";

            PagedResponseCollection<FilterPrivateDomainsByNameResponse> page = Utilities.DeserializePage<FilterPrivateDomainsByNameResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("d17494ef-23b8-43ba-a056-b12a5906d91a", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/1780bb83-34c0-4bfb-9843-2a701b863517", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("d17494ef-23b8-43ba-a056-b12a5906d91a", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/c38f327c-95e8-4e15-b08b-bc62b963be6f", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/1780bb83-34c0-4bfb-9843-2a701b863517/shared_organizations", TestUtil.ToTestableString(page[0].SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestListAllPrivateDomainsResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""url"": ""/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59"",
        ""created_at"": ""2016-05-05T14:14:47Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""owning_organization_url"": ""/v2/organizations/69275b67-e9ee-4542-839f-228a1c7c9827"",
        ""shared_organizations_url"": ""/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""url"": ""/v2/private_domains/aef54465-f541-482c-a07e-089b87e9b655"",
        ""created_at"": ""2016-05-05T14:15:00Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-55.example.com"",
        ""owning_organization_guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""owning_organization_url"": ""/v2/organizations/b667e3c3-b45b-458b-962b-0dd12d7dca12"",
        ""shared_organizations_url"": ""/v2/private_domains/aef54465-f541-482c-a07e-089b87e9b655/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""url"": ""/v2/private_domains/496f8b12-c5cf-4828-819b-80efcef07e4a"",
        ""created_at"": ""2016-05-05T14:15:00Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-56.example.com"",
        ""owning_organization_guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""owning_organization_url"": ""/v2/organizations/9883929c-252a-4c82-bed2-6a944569755e"",
        ""shared_organizations_url"": ""/v2/private_domains/496f8b12-c5cf-4828-819b-80efcef07e4a/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""url"": ""/v2/private_domains/af68c650-b8a0-4c16-bbf6-53411db114e0"",
        ""created_at"": ""2016-05-05T14:15:00Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-57.example.com"",
        ""owning_organization_guid"": ""9c839804-a236-4690-8a59-1e19c4e119b8"",
        ""owning_organization_url"": ""/v2/organizations/463e8180-2990-4410-a85c-b41486fd7be1"",
        ""shared_organizations_url"": ""/v2/private_domains/af68c650-b8a0-4c16-bbf6-53411db114e0/shared_organizations""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllPrivateDomainsResponse> page = Utilities.DeserializePage<ListAllPrivateDomainsResponse>(json, null);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:47Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/69275b67-e9ee-4542-839f-228a1c7c9827", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/858beb2d-6f30-462e-8913-a5bb370e8f59/shared_organizations", TestUtil.ToTestableString(page[0].SharedOrganizationsUrl), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/aef54465-f541-482c-a07e-089b87e9b655", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-55.example.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[1].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/b667e3c3-b45b-458b-962b-0dd12d7dca12", TestUtil.ToTestableString(page[1].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/aef54465-f541-482c-a07e-089b87e9b655/shared_organizations", TestUtil.ToTestableString(page[1].SharedOrganizationsUrl), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/496f8b12-c5cf-4828-819b-80efcef07e4a", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-56.example.com", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/9883929c-252a-4c82-bed2-6a944569755e", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/496f8b12-c5cf-4828-819b-80efcef07e4a/shared_organizations", TestUtil.ToTestableString(page[2].SharedOrganizationsUrl), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/af68c650-b8a0-4c16-bbf6-53411db114e0", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-57.example.com", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("9c839804-a236-4690-8a59-1e19c4e119b8", TestUtil.ToTestableString(page[3].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/463e8180-2990-4410-a85c-b41486fd7be1", TestUtil.ToTestableString(page[3].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/af68c650-b8a0-4c16-bbf6-53411db114e0/shared_organizations", TestUtil.ToTestableString(page[3].SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestListAllSharedOrganizationsForPrivateDomainResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f216d5b5-90f5-4457-9004-60e3bce6bde8"",
        ""url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee"",
        ""created_at"": ""2016-05-05T14:15:00Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1414"",
        ""billing_enabled"": false,
        ""quota_definition_guid"": ""f216d5b5-90f5-4457-9004-60e3bce6bde8"",
        ""status"": ""active"",
        ""quota_definition_url"": ""/v2/quota_definitions/4eabafa4-b9f2-4dd6-9f95-dddb5aea851a"",
        ""spaces_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/spaces"",
        ""domains_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/domains"",
        ""private_domains_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/private_domains"",
        ""users_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/users"",
        ""managers_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/managers"",
        ""billing_managers_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/billing_managers"",
        ""auditors_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/auditors"",
        ""app_events_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/app_events"",
        ""space_quota_definitions_url"": ""/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/space_quota_definitions""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSharedOrganizationsForPrivateDomainResponse> page = Utilities.DeserializePage<ListAllSharedOrganizationsForPrivateDomainResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f216d5b5-90f5-4457-9004-60e3bce6bde8", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1414", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].BillingEnabled), true);
            Assert.AreEqual("f216d5b5-90f5-4457-9004-60e3bce6bde8", TestUtil.ToTestableString(page[0].QuotaDefinitionGuid), true);
            Assert.AreEqual("active", TestUtil.ToTestableString(page[0].Status), true);
            Assert.AreEqual("/v2/quota_definitions/4eabafa4-b9f2-4dd6-9f95-dddb5aea851a", TestUtil.ToTestableString(page[0].QuotaDefinitionUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/private_domains", TestUtil.ToTestableString(page[0].PrivateDomainsUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/users", TestUtil.ToTestableString(page[0].UsersUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/billing_managers", TestUtil.ToTestableString(page[0].BillingManagersUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/organizations/f5888d6a-9fc7-4035-b8a4-68e0bf63cbee/space_quota_definitions", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionsUrl), true);
        }

        [TestMethod]
        public void TestCreatePrivateDomainOwnedByGivenOrganizationResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""109ebe79-db7e-477f-8da7-6d12fc3b1d4e"",
    ""url"": ""/v2/private_domains/cccbd9f2-be16-4d47-bc6d-7b3e17cda7e7"",
    ""created_at"": ""2016-05-05T14:15:00Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""109ebe79-db7e-477f-8da7-6d12fc3b1d4e"",
    ""owning_organization_url"": ""/v2/organizations/754a4d0e-ac05-45bf-a8d4-5ece31fa750f"",
    ""shared_organizations_url"": ""/v2/private_domains/cccbd9f2-be16-4d47-bc6d-7b3e17cda7e7/shared_organizations""
  }
}";

            CreatePrivateDomainOwnedByGivenOrganizationResponse obj = Utilities.DeserializeJson<CreatePrivateDomainOwnedByGivenOrganizationResponse>(json);

            Assert.AreEqual("109ebe79-db7e-477f-8da7-6d12fc3b1d4e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/cccbd9f2-be16-4d47-bc6d-7b3e17cda7e7", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("109ebe79-db7e-477f-8da7-6d12fc3b1d4e", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/754a4d0e-ac05-45bf-a8d4-5ece31fa750f", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/cccbd9f2-be16-4d47-bc6d-7b3e17cda7e7/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);
        }
    }
}
