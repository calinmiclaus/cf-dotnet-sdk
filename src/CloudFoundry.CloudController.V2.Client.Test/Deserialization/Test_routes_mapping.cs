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
    public class RoutesMappingTest
    {


        [TestMethod]
        public void TestListAllRouteMappingsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""452f9f4a-1aaf-472c-8b30-39243c50b908"",
        ""url"": ""/v2/route_mappings/057b65cd-362d-4168-b4a6-9a6869979e55"",
        ""created_at"": ""2016-05-05T14:15:16Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_port"": 8888,
        ""app_guid"": ""452f9f4a-1aaf-472c-8b30-39243c50b908"",
        ""route_guid"": ""452f9f4a-1aaf-472c-8b30-39243c50b908"",
        ""app_url"": ""/v2/apps/68a7219b-c79e-450b-a38c-dfb4dd88f657"",
        ""route_url"": ""/v2/routes/2c4824f1-d385-4323-8275-507f9b88b098""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRouteMappingsResponse> page = Utilities.DeserializePage<ListAllRouteMappingsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("452f9f4a-1aaf-472c-8b30-39243c50b908", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/057b65cd-362d-4168-b4a6-9a6869979e55", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:16Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8888", TestUtil.ToTestableString(page[0].AppPort), true);
            Assert.AreEqual("452f9f4a-1aaf-472c-8b30-39243c50b908", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("452f9f4a-1aaf-472c-8b30-39243c50b908", TestUtil.ToTestableString(page[0].RouteGuid), true);
            Assert.AreEqual("/v2/apps/68a7219b-c79e-450b-a38c-dfb4dd88f657", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/routes/2c4824f1-d385-4323-8275-507f9b88b098", TestUtil.ToTestableString(page[0].RouteUrl), true);
        }

        [TestMethod]
        public void TestMappingAppAndRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d33d9925-d9d5-43cd-b396-846e66aa59ea"",
    ""url"": ""/v2/route_mappings/de533a72-d2b3-424f-8f05-07f063b16d4c"",
    ""created_at"": ""2016-05-05T14:15:16Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_port"": 8888,
    ""app_guid"": ""d33d9925-d9d5-43cd-b396-846e66aa59ea"",
    ""route_guid"": ""d33d9925-d9d5-43cd-b396-846e66aa59ea"",
    ""app_url"": ""/v2/apps/ebc39f66-f7eb-4241-ad0e-909182b3841f"",
    ""route_url"": ""/v2/routes/d49ad65e-188e-497d-863b-6bc04e31ede2""
  }
}";

            MappingAppAndRouteResponse obj = Utilities.DeserializeJson<MappingAppAndRouteResponse>(json);

            Assert.AreEqual("d33d9925-d9d5-43cd-b396-846e66aa59ea", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/de533a72-d2b3-424f-8f05-07f063b16d4c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8888", TestUtil.ToTestableString(obj.AppPort), true);
            Assert.AreEqual("d33d9925-d9d5-43cd-b396-846e66aa59ea", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("d33d9925-d9d5-43cd-b396-846e66aa59ea", TestUtil.ToTestableString(obj.RouteGuid), true);
            Assert.AreEqual("/v2/apps/ebc39f66-f7eb-4241-ad0e-909182b3841f", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/routes/d49ad65e-188e-497d-863b-6bc04e31ede2", TestUtil.ToTestableString(obj.RouteUrl), true);
        }

        [TestMethod]
        public void TestUpdateRouteMappingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""b8cf4206-9f27-43db-9ea6-4a4a07bf6049"",
    ""url"": ""/v2/route_mappings/94407fd2-1bea-44f1-a139-a19eeb9bc594"",
    ""created_at"": ""2016-05-05T14:15:16Z"",
    ""updated_at"": ""2016-05-05T14:15:16Z""
  },
  ""entity"": {
    ""app_port"": 8889,
    ""app_guid"": ""b8cf4206-9f27-43db-9ea6-4a4a07bf6049"",
    ""route_guid"": ""b8cf4206-9f27-43db-9ea6-4a4a07bf6049"",
    ""app_url"": ""/v2/apps/c524911f-39f9-4300-9fa9-f070111772d3"",
    ""route_url"": ""/v2/routes/7ac627d8-0841-47a9-988c-c03ecb2d54fd""
  }
}";

            UpdateRouteMappingResponse obj = Utilities.DeserializeJson<UpdateRouteMappingResponse>(json);

            Assert.AreEqual("b8cf4206-9f27-43db-9ea6-4a4a07bf6049", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/94407fd2-1bea-44f1-a139-a19eeb9bc594", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-05T14:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8889", TestUtil.ToTestableString(obj.AppPort), true);
            Assert.AreEqual("b8cf4206-9f27-43db-9ea6-4a4a07bf6049", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("b8cf4206-9f27-43db-9ea6-4a4a07bf6049", TestUtil.ToTestableString(obj.RouteGuid), true);
            Assert.AreEqual("/v2/apps/c524911f-39f9-4300-9fa9-f070111772d3", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/routes/7ac627d8-0841-47a9-988c-c03ecb2d54fd", TestUtil.ToTestableString(obj.RouteUrl), true);
        }

        [TestMethod]
        public void TestRetrieveRouteMappingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""504b1224-e82c-4b71-9b61-584aba53b2ce"",
    ""url"": ""/v2/route_mappings/a606dd4e-15a7-4d21-b88a-d80f2d23a39b"",
    ""created_at"": ""2016-05-05T14:15:16Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_port"": 8888,
    ""app_guid"": ""504b1224-e82c-4b71-9b61-584aba53b2ce"",
    ""route_guid"": ""504b1224-e82c-4b71-9b61-584aba53b2ce"",
    ""app_url"": ""/v2/apps/0b43d903-2d35-4630-89f0-44e30c51c464"",
    ""route_url"": ""/v2/routes/542af197-c4bc-4d66-aa58-20f48acb9012""
  }
}";

            RetrieveRouteMappingResponse obj = Utilities.DeserializeJson<RetrieveRouteMappingResponse>(json);

            Assert.AreEqual("504b1224-e82c-4b71-9b61-584aba53b2ce", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/a606dd4e-15a7-4d21-b88a-d80f2d23a39b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8888", TestUtil.ToTestableString(obj.AppPort), true);
            Assert.AreEqual("504b1224-e82c-4b71-9b61-584aba53b2ce", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("504b1224-e82c-4b71-9b61-584aba53b2ce", TestUtil.ToTestableString(obj.RouteGuid), true);
            Assert.AreEqual("/v2/apps/0b43d903-2d35-4630-89f0-44e30c51c464", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/routes/542af197-c4bc-4d66-aa58-20f48acb9012", TestUtil.ToTestableString(obj.RouteUrl), true);
        }
    }
}
