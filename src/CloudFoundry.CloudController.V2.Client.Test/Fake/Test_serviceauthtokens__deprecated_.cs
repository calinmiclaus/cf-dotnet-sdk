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
    public class ServiceAuthTokensDeprecatedEndpoint
{
        [TestMethod]
        public void FilterResultSetByLabelDeprecatedTest()
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
        ""guid"": ""79423ad9-d7f3-4694-af71-cd24f03022c3"",
        ""url"": ""/v2/service_auth_tokens/402b0f2a-0c94-416b-81d1-568e81859737"",
        ""created_at"": ""2016-04-28T14:32:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""Nic-Token"",
        ""provider"": ""provider-7""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.FilterResultSetByLabelDeprecated().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("79423ad9-d7f3-4694-af71-cd24f03022c3", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/402b0f2a-0c94-416b-81d1-568e81859737", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-28T14:32:10Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("Nic-Token", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("provider-7", TestUtil.ToTestableString(obj[0].Provider), true);

            }
        }

        [TestMethod]
        public void ListAllServiceAuthTokensDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d16a8ad8-7ac6-4f32-af13-41ad1a92e171"",
        ""url"": ""/v2/service_auth_tokens/9f20be2c-7b0f-40c2-b8ba-6311172f6643"",
        ""created_at"": ""2016-04-28T14:32:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-14"",
        ""provider"": ""provider-14""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d16a8ad8-7ac6-4f32-af13-41ad1a92e171"",
        ""url"": ""/v2/service_auth_tokens/12af73ea-6674-443c-bad3-ec190c214bb4"",
        ""created_at"": ""2016-04-28T14:32:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-15"",
        ""provider"": ""provider-15""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d16a8ad8-7ac6-4f32-af13-41ad1a92e171"",
        ""url"": ""/v2/service_auth_tokens/8ee3345c-86b7-48c7-9c54-780f44b1bcae"",
        ""created_at"": ""2016-04-28T14:32:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-16"",
        ""provider"": ""provider-16""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.ListAllServiceAuthTokensDeprecated().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("d16a8ad8-7ac6-4f32-af13-41ad1a92e171", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/9f20be2c-7b0f-40c2-b8ba-6311172f6643", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-28T14:32:10Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-14", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("provider-14", TestUtil.ToTestableString(obj[0].Provider), true);
                Assert.AreEqual("d16a8ad8-7ac6-4f32-af13-41ad1a92e171", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/12af73ea-6674-443c-bad3-ec190c214bb4", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-28T14:32:10Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-15", TestUtil.ToTestableString(obj[1].Label), true);
                Assert.AreEqual("provider-15", TestUtil.ToTestableString(obj[1].Provider), true);
                Assert.AreEqual("d16a8ad8-7ac6-4f32-af13-41ad1a92e171", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/8ee3345c-86b7-48c7-9c54-780f44b1bcae", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-28T14:32:10Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-16", TestUtil.ToTestableString(obj[2].Label), true);
                Assert.AreEqual("provider-16", TestUtil.ToTestableString(obj[2].Provider), true);

            }
        }

        [TestMethod]
        public void FilterResultSetByProviderDeprecatedTest()
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
        ""guid"": ""092d7bfc-1357-4984-bdda-8b8fb52a9067"",
        ""url"": ""/v2/service_auth_tokens/c0ebc5bf-24c9-418c-8718-e8954931e8a9"",
        ""created_at"": ""2016-04-28T14:32:10Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-4"",
        ""provider"": ""Face-Offer""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.FilterResultSetByProviderDeprecated().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("092d7bfc-1357-4984-bdda-8b8fb52a9067", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/c0ebc5bf-24c9-418c-8718-e8954931e8a9", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-28T14:32:10Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-4", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("Face-Offer", TestUtil.ToTestableString(obj[0].Provider), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceAuthTokenDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4fef25da-3424-4ad0-b65b-ee3353effd95"",
    ""url"": ""/v2/service_auth_tokens/4726b31d-2383-426e-9388-e48ae99eba91"",
    ""created_at"": ""2016-04-28T14:32:10Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-8"",
    ""provider"": ""provider-8""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceAuthTokensDeprecated.RetrieveServiceAuthTokenDeprecated(guid).Result;


                Assert.AreEqual("4fef25da-3424-4ad0-b65b-ee3353effd95", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/4726b31d-2383-426e-9388-e48ae99eba91", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-28T14:32:10Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-8", TestUtil.ToTestableString(obj.Label), true);
                Assert.AreEqual("provider-8", TestUtil.ToTestableString(obj.Provider), true);

            }
        }

        [TestMethod]
        public void DeleteServiceAuthTokenDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceAuthTokensDeprecated.DeleteServiceAuthTokenDeprecated(guid).Wait();

            }
        }

    }
}