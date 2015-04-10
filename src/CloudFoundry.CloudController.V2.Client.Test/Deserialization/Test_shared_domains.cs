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
    public class SharedDomainsTest
    {


        [TestMethod]
        public void TestFilterSharedDomainsByNameResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""fe86e084-8eb8-4b15-b312-be5c0e96126f"",
        ""url"": ""/v2/shared_domains/fe86e084-8eb8-4b15-b312-be5c0e96126f"",
        ""created_at"": ""2015-04-10T20:04:35+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""shared-domain.com""
      }
    }
  ]
}";

            PagedResponseCollection<FilterSharedDomainsByNameResponse> page = Utilities.DeserializePage<FilterSharedDomainsByNameResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("fe86e084-8eb8-4b15-b312-be5c0e96126f", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/fe86e084-8eb8-4b15-b312-be5c0e96126f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:35+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("shared-domain.com", TestUtil.ToTestableString(page[0].Name), true);
        }

        [TestMethod]
        public void TestCreateSharedDomainResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""be188d0a-8b88-4bf2-8a3f-b6f666d382b2"",
    ""url"": ""/v2/shared_domains/be188d0a-8b88-4bf2-8a3f-b6f666d382b2"",
    ""created_at"": ""2015-04-10T20:04:35+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com""
  }
}";

            CreateSharedDomainResponse obj = Utilities.DeserializeJson<CreateSharedDomainResponse>(json);

            Assert.AreEqual("be188d0a-8b88-4bf2-8a3f-b6f666d382b2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/be188d0a-8b88-4bf2-8a3f-b6f666d382b2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:35+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
        }

        [TestMethod]
        public void TestListAllSharedDomainsResponse()
        {
            string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""8c827319-3606-4bae-9e9b-6816cde64a57"",
        ""url"": ""/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57"",
        ""created_at"": ""2015-04-10T20:04:27+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d616b632-3803-400c-b732-46a3709542fc"",
        ""url"": ""/v2/shared_domains/d616b632-3803-400c-b732-46a3709542fc"",
        ""created_at"": ""2015-04-10T20:04:27+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""77fa1559-6d11-424c-97c1-e2c5165f902c"",
        ""url"": ""/v2/shared_domains/77fa1559-6d11-424c-97c1-e2c5165f902c"",
        ""created_at"": ""2015-04-10T20:04:34+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-28.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ef8d39eb-7171-4f87-bd06-ea0ff9652ce2"",
        ""url"": ""/v2/shared_domains/ef8d39eb-7171-4f87-bd06-ea0ff9652ce2"",
        ""created_at"": ""2015-04-10T20:04:34+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-29.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""eb851a96-114b-4212-b65d-e621b6caeb7f"",
        ""url"": ""/v2/shared_domains/eb851a96-114b-4212-b65d-e621b6caeb7f"",
        ""created_at"": ""2015-04-10T20:04:34+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-30.example.com""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSharedDomainsResponse> page = Utilities.DeserializePage<ListAllSharedDomainsResponse>(json, null);

            Assert.AreEqual("5", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("d616b632-3803-400c-b732-46a3709542fc", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/d616b632-3803-400c-b732-46a3709542fc", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("77fa1559-6d11-424c-97c1-e2c5165f902c", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/77fa1559-6d11-424c-97c1-e2c5165f902c", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:34+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-28.example.com", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("ef8d39eb-7171-4f87-bd06-ea0ff9652ce2", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/ef8d39eb-7171-4f87-bd06-ea0ff9652ce2", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:34+00:00", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-29.example.com", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("eb851a96-114b-4212-b65d-e621b6caeb7f", TestUtil.ToTestableString(page[4].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/eb851a96-114b-4212-b65d-e621b6caeb7f", TestUtil.ToTestableString(page[4].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:34+00:00", TestUtil.ToTestableString(page[4].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[4].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-30.example.com", TestUtil.ToTestableString(page[4].Name), true);
        }

        [TestMethod]
        public void TestRetrieveSharedDomainResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8c827319-3606-4bae-9e9b-6816cde64a57"",
    ""url"": ""/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57"",
    ""created_at"": ""2015-04-10T20:04:27+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""customer-app-domain1.com""
  }
}";

            RetrieveSharedDomainResponse obj = Utilities.DeserializeJson<RetrieveSharedDomainResponse>(json);

            Assert.AreEqual("8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj.Name), true);
        }
    }
}
