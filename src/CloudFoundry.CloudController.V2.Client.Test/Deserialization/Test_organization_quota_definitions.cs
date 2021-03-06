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
    public class OrganizationQuotaDefinitionsTest
    {


        [TestMethod]
        public void TestUpdateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d4158400-8775-44e3-bb69-27395f339f53"",
    ""url"": ""/v2/quota_definitions/860f135a-e383-493d-b509-9526e388cc66"",
    ""created_at"": ""2016-05-05T14:15:17Z"",
    ""updated_at"": ""2016-05-05T14:15:17Z""
  },
  ""entity"": {
    ""name"": ""name-1712"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""total_private_domains"": -1,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": -1,
    ""total_service_keys"": -1,
    ""total_reserved_route_ports"": 5
  }
}";

            UpdateOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<UpdateOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("d4158400-8775-44e3-bb69-27395f339f53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/860f135a-e383-493d-b509-9526e388cc66", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:17Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-05T14:15:17Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1712", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalPrivateDomains), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
        }

        [TestMethod]
        public void TestRetrieveOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""e941ecc2-b49b-4b0d-816c-6874d11f3a02"",
    ""url"": ""/v2/quota_definitions/de797a8a-2f43-4568-b79a-79b941edb61f"",
    ""created_at"": ""2016-05-05T14:15:17Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1714"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""total_private_domains"": -1,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": -1,
    ""total_service_keys"": -1,
    ""total_reserved_route_ports"": 5
  }
}";

            RetrieveOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<RetrieveOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("e941ecc2-b49b-4b0d-816c-6874d11f3a02", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/de797a8a-2f43-4568-b79a-79b941edb61f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:17Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1714", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalPrivateDomains), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
        }

        [TestMethod]
        public void TestCreateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""13afba86-9c4a-4c94-be95-a2e7ace49c80"",
    ""url"": ""/v2/quota_definitions/225c23cf-0c80-444e-81a9-57fea892bd7e"",
    ""created_at"": ""2016-05-05T14:15:17Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""non_basic_services_allowed"": true,
    ""total_services"": -1,
    ""total_routes"": 4,
    ""total_private_domains"": -1,
    ""memory_limit"": 5120,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": 10240,
    ""app_instance_limit"": 10,
    ""app_task_limit"": 5,
    ""total_service_keys"": -1,
    ""total_reserved_route_ports"": 3
  }
}";

            CreateOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<CreateOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("13afba86-9c4a-4c94-be95-a2e7ace49c80", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/225c23cf-0c80-444e-81a9-57fea892bd7e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:17Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("4", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalPrivateDomains), true);
            Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("10", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("3", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
        }

        [TestMethod]
        public void TestListAllOrganizationQuotaDefinitionsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""e67c32c8-0747-409e-8863-ce4548227645"",
        ""url"": ""/v2/quota_definitions/f25bbb27-dac1-401c-8a39-2a3c42e15a79"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 100,
        ""total_routes"": 1000,
        ""total_private_domains"": -1,
        ""memory_limit"": 10240,
        ""trial_db_allowed"": false,
        ""instance_memory_limit"": -1,
        ""app_instance_limit"": -1,
        ""app_task_limit"": -1,
        ""total_service_keys"": -1,
        ""total_reserved_route_ports"": 0
      }
    }
  ]
}";

            PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse> page = Utilities.DeserializePage<ListAllOrganizationQuotaDefinitionsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("e67c32c8-0747-409e-8863-ce4548227645", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/f25bbb27-dac1-401c-8a39-2a3c42e15a79", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("default", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].NonBasicServicesAllowed), true);
            Assert.AreEqual("100", TestUtil.ToTestableString(page[0].TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(page[0].TotalRoutes), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].TotalPrivateDomains), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(page[0].MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].AppInstanceLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].AppTaskLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].TotalServiceKeys), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(page[0].TotalReservedRoutePorts), true);
        }
    }
}
