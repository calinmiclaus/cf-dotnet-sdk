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
        ""guid"": ""69635e74-c25f-46ee-bb2f-3ed668e3db85"",
        ""url"": ""/v2/route_mappings/c76935ad-4790-4ed2-b6f4-2556fc65bb4e"",
        ""created_at"": ""2016-04-11T13:32:36Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_port"": 8888,
        ""app_guid"": ""69635e74-c25f-46ee-bb2f-3ed668e3db85"",
        ""route_guid"": ""69635e74-c25f-46ee-bb2f-3ed668e3db85"",
        ""app_url"": ""/v2/apps/02c2934e-17d0-4f3b-bb74-6361df5989ff"",
        ""route_url"": ""/v2/routes/0c8b0aa3-6212-40ba-844c-b706334131a0""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRouteMappingsResponse> page = Utilities.DeserializePage<ListAllRouteMappingsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("69635e74-c25f-46ee-bb2f-3ed668e3db85", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/c76935ad-4790-4ed2-b6f4-2556fc65bb4e", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8888", TestUtil.ToTestableString(page[0].AppPort), true);
            Assert.AreEqual("69635e74-c25f-46ee-bb2f-3ed668e3db85", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("69635e74-c25f-46ee-bb2f-3ed668e3db85", TestUtil.ToTestableString(page[0].RouteGuid), true);
            Assert.AreEqual("/v2/apps/02c2934e-17d0-4f3b-bb74-6361df5989ff", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/routes/0c8b0aa3-6212-40ba-844c-b706334131a0", TestUtil.ToTestableString(page[0].RouteUrl), true);
        }

        [TestMethod]
        public void TestMappingAppAndRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c89e1b8a-cddc-480e-b8c7-eaa73f0cc357"",
    ""url"": ""/v2/route_mappings/671382c1-7a65-4294-94cd-332cc64df1a9"",
    ""created_at"": ""2016-04-11T13:32:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_port"": 8888,
    ""app_guid"": ""c89e1b8a-cddc-480e-b8c7-eaa73f0cc357"",
    ""route_guid"": ""c89e1b8a-cddc-480e-b8c7-eaa73f0cc357"",
    ""app_url"": ""/v2/apps/687937b4-4327-4323-a6ef-af35804c2244"",
    ""route_url"": ""/v2/routes/bbc0872b-8fe4-4204-b91f-99f57be3dbb2""
  }
}";

            MappingAppAndRouteResponse obj = Utilities.DeserializeJson<MappingAppAndRouteResponse>(json);

            Assert.AreEqual("c89e1b8a-cddc-480e-b8c7-eaa73f0cc357", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/671382c1-7a65-4294-94cd-332cc64df1a9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8888", TestUtil.ToTestableString(obj.AppPort), true);
            Assert.AreEqual("c89e1b8a-cddc-480e-b8c7-eaa73f0cc357", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("c89e1b8a-cddc-480e-b8c7-eaa73f0cc357", TestUtil.ToTestableString(obj.RouteGuid), true);
            Assert.AreEqual("/v2/apps/687937b4-4327-4323-a6ef-af35804c2244", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/routes/bbc0872b-8fe4-4204-b91f-99f57be3dbb2", TestUtil.ToTestableString(obj.RouteUrl), true);
        }

        [TestMethod]
        public void TestUpdateRouteMappingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""11520026-1218-46cf-b2f8-e64519efb0ef"",
    ""url"": ""/v2/route_mappings/ed454143-50b4-47e1-8c9a-7c7efd94030d"",
    ""created_at"": ""2016-04-11T13:32:36Z"",
    ""updated_at"": ""2016-04-11T13:32:36Z""
  },
  ""entity"": {
    ""app_port"": 8889,
    ""app_guid"": ""11520026-1218-46cf-b2f8-e64519efb0ef"",
    ""route_guid"": ""11520026-1218-46cf-b2f8-e64519efb0ef"",
    ""app_url"": ""/v2/apps/5dd98c82-09fe-4941-bce8-2be461a7c049"",
    ""route_url"": ""/v2/routes/3c08ae3b-8663-4363-a53f-c324cc6a1bb3""
  }
}";

            UpdateRouteMappingResponse obj = Utilities.DeserializeJson<UpdateRouteMappingResponse>(json);

            Assert.AreEqual("11520026-1218-46cf-b2f8-e64519efb0ef", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/ed454143-50b4-47e1-8c9a-7c7efd94030d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8889", TestUtil.ToTestableString(obj.AppPort), true);
            Assert.AreEqual("11520026-1218-46cf-b2f8-e64519efb0ef", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("11520026-1218-46cf-b2f8-e64519efb0ef", TestUtil.ToTestableString(obj.RouteGuid), true);
            Assert.AreEqual("/v2/apps/5dd98c82-09fe-4941-bce8-2be461a7c049", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/routes/3c08ae3b-8663-4363-a53f-c324cc6a1bb3", TestUtil.ToTestableString(obj.RouteUrl), true);
        }

        [TestMethod]
        public void TestRetrieveRouteMappingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""7db32d95-3d08-497e-8f9b-89d31c9b3fad"",
    ""url"": ""/v2/route_mappings/6f1c5f8e-1d9f-4732-a65e-2f664a34495b"",
    ""created_at"": ""2016-04-11T13:32:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_port"": 8888,
    ""app_guid"": ""7db32d95-3d08-497e-8f9b-89d31c9b3fad"",
    ""route_guid"": ""7db32d95-3d08-497e-8f9b-89d31c9b3fad"",
    ""app_url"": ""/v2/apps/c43bf31b-dd9e-44f6-9b26-88d038a798a5"",
    ""route_url"": ""/v2/routes/48811f9b-d21f-4bac-9e17-b5797462eeb3""
  }
}";

            RetrieveRouteMappingResponse obj = Utilities.DeserializeJson<RetrieveRouteMappingResponse>(json);

            Assert.AreEqual("7db32d95-3d08-497e-8f9b-89d31c9b3fad", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/route_mappings/6f1c5f8e-1d9f-4732-a65e-2f664a34495b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8888", TestUtil.ToTestableString(obj.AppPort), true);
            Assert.AreEqual("7db32d95-3d08-497e-8f9b-89d31c9b3fad", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("7db32d95-3d08-497e-8f9b-89d31c9b3fad", TestUtil.ToTestableString(obj.RouteGuid), true);
            Assert.AreEqual("/v2/apps/c43bf31b-dd9e-44f6-9b26-88d038a798a5", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/routes/48811f9b-d21f-4bac-9e17-b5797462eeb3", TestUtil.ToTestableString(obj.RouteUrl), true);
        }
    }
}