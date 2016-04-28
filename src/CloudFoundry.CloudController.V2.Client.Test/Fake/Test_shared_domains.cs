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
    public class SharedDomainsEndpoint
{
        [TestMethod]
        public void DeleteSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SharedDomains.DeleteSharedDomain(guid).Wait();

            }
        }

        [TestMethod]
        public void CreateSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""d3254fc8-d1fd-4bfc-a440-8787ec4e44e9"",
    ""url"": ""/v2/shared_domains/df8f7f81-068e-41e8-a1b6-bae19caf90a0"",
    ""created_at"": ""2016-05-05T14:14:49Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com"",
    ""router_group_guid"": ""d3254fc8-d1fd-4bfc-a440-8787ec4e44e9"",
    ""router_group_type"": ""tcp""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSharedDomainRequest value = new CreateSharedDomainRequest();


                var obj = cfClient.SharedDomains.CreateSharedDomain(value).Result;


                Assert.AreEqual("d3254fc8-d1fd-4bfc-a440-8787ec4e44e9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/df8f7f81-068e-41e8-a1b6-bae19caf90a0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("d3254fc8-d1fd-4bfc-a440-8787ec4e44e9", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
                Assert.AreEqual("tcp", TestUtil.ToTestableString(obj.RouterGroupType), true);

            }
        }

        [TestMethod]
        public void RetrieveSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""ad355536-39d0-4b4c-8198-388210f86c38"",
    ""url"": ""/v2/shared_domains/f1643d70-1174-4b49-9eb2-6688b4e57950"",
    ""created_at"": ""2016-05-05T14:14:47Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""customer-app-domain1.com"",
    ""router_group_guid"": null,
    ""router_group_type"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SharedDomains.RetrieveSharedDomain(guid).Result;


                Assert.AreEqual("ad355536-39d0-4b4c-8198-388210f86c38", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/f1643d70-1174-4b49-9eb2-6688b4e57950", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:47Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupType), true);

            }
        }

        [TestMethod]
        public void FilterSharedDomainsByNameTest()
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
        ""guid"": ""aec1378e-d0fb-4f3a-86d6-5fd98bee0c2c"",
        ""url"": ""/v2/shared_domains/7f4f72c8-8b4d-4285-a971-09aa95ef8555"",
        ""created_at"": ""2016-05-05T14:14:49Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""shared-domain.com"",
        ""router_group_guid"": ""aec1378e-d0fb-4f3a-86d6-5fd98bee0c2c"",
        ""router_group_type"": ""tcp""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.FilterSharedDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("aec1378e-d0fb-4f3a-86d6-5fd98bee0c2c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/7f4f72c8-8b4d-4285-a971-09aa95ef8555", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("shared-domain.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("aec1378e-d0fb-4f3a-86d6-5fd98bee0c2c", TestUtil.ToTestableString(obj[0].RouterGroupGuid), true);
                Assert.AreEqual("tcp", TestUtil.ToTestableString(obj[0].RouterGroupType), true);

            }
        }

        [TestMethod]
        public void ListAllSharedDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 6,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""url"": ""/v2/shared_domains/f1643d70-1174-4b49-9eb2-6688b4e57950"",
        ""created_at"": ""2016-05-05T14:14:47Z"",
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
        ""guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""url"": ""/v2/shared_domains/2eae87ab-62a6-47ef-9b4e-ffba76153d47"",
        ""created_at"": ""2016-05-05T14:14:47Z"",
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
        ""guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""url"": ""/v2/shared_domains/28014b80-d490-4148-9a9b-53edb475527a"",
        ""created_at"": ""2016-05-05T14:14:49Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-21.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""url"": ""/v2/shared_domains/1f6e2abb-0f8a-4448-ae84-ba5536e7eba9"",
        ""created_at"": ""2016-05-05T14:14:49Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-22.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""url"": ""/v2/shared_domains/b2faff5e-db0a-421f-80a1-d375003258f3"",
        ""created_at"": ""2016-05-05T14:14:49Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-23.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""url"": ""/v2/shared_domains/30fce782-1c62-4492-9b52-dfe52c8f2bd8"",
        ""created_at"": ""2016-05-05T14:14:49Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-24.example.com"",
        ""router_group_guid"": ""5547aa37-d861-4bd8-b00b-63f7eed3f8b3"",
        ""router_group_type"": ""tcp""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.ListAllSharedDomains().Result;

                Assert.AreEqual("6", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/f1643d70-1174-4b49-9eb2-6688b4e57950", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:47Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouterGroupType), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/2eae87ab-62a6-47ef-9b4e-ffba76153d47", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:47Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].RouterGroupType), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/28014b80-d490-4148-9a9b-53edb475527a", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-21.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].RouterGroupType), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/1f6e2abb-0f8a-4448-ae84-ba5536e7eba9", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-22.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].RouterGroupType), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/b2faff5e-db0a-421f-80a1-d375003258f3", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-23.example.com", TestUtil.ToTestableString(obj[4].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].RouterGroupType), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[5].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/30fce782-1c62-4492-9b52-dfe52c8f2bd8", TestUtil.ToTestableString(obj[5].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj[5].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[5].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-24.example.com", TestUtil.ToTestableString(obj[5].Name), true);
                Assert.AreEqual("5547aa37-d861-4bd8-b00b-63f7eed3f8b3", TestUtil.ToTestableString(obj[5].RouterGroupGuid), true);
                Assert.AreEqual("tcp", TestUtil.ToTestableString(obj[5].RouterGroupType), true);

            }
        }

    }
}