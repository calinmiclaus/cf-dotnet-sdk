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
    public class StacksEndpoint
{
        [TestMethod]
        public void ListAllStacksTest()
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
        ""guid"": ""b66dbbda-c4d1-4e15-be74-8f2b98cb7f90"",
        ""url"": ""/v2/stacks/03ebfd2b-bc83-44aa-bd44-558acd5a1b8d"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cflinuxfs2"",
        ""description"": ""cflinuxfs2""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b66dbbda-c4d1-4e15-be74-8f2b98cb7f90"",
        ""url"": ""/v2/stacks/455c65e4-f114-4c94-adcc-e1d9cdcac4b1"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b66dbbda-c4d1-4e15-be74-8f2b98cb7f90"",
        ""url"": ""/v2/stacks/9c13776c-dac3-492f-9d80-42862588b895"",
        ""created_at"": ""2016-05-05T14:15:13Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cider"",
        ""description"": ""cider-description""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Stacks.ListAllStacks().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("b66dbbda-c4d1-4e15-be74-8f2b98cb7f90", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/03ebfd2b-bc83-44aa-bd44-558acd5a1b8d", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("b66dbbda-c4d1-4e15-be74-8f2b98cb7f90", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/455c65e4-f114-4c94-adcc-e1d9cdcac4b1", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(obj[1].Description), true);
                Assert.AreEqual("b66dbbda-c4d1-4e15-be74-8f2b98cb7f90", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/9c13776c-dac3-492f-9d80-42862588b895", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cider", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("cider-description", TestUtil.ToTestableString(obj[2].Description), true);

            }
        }

        [TestMethod]
        public void RetrieveStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""9ef1eaa8-4197-48da-a1cc-ff266af204f7"",
    ""url"": ""/v2/stacks/03ebfd2b-bc83-44aa-bd44-558acd5a1b8d"",
    ""created_at"": ""2016-05-05T14:15:13Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""cflinuxfs2"",
    ""description"": ""cflinuxfs2""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Stacks.RetrieveStack(guid).Result;


                Assert.AreEqual("9ef1eaa8-4197-48da-a1cc-ff266af204f7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/03ebfd2b-bc83-44aa-bd44-558acd5a1b8d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Description), true);

            }
        }

        [TestMethod]
        public void CreateStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f604c830-eadf-4fd9-9e84-a2675261ddb2"",
    ""url"": ""/v2/stacks/1e68f561-7ada-4861-b308-c2026e2bf530"",
    ""created_at"": ""2016-05-05T14:15:13Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example_stack"",
    ""description"": ""Description for the example stack""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateStackRequest value = new CreateStackRequest();


                var obj = cfClient.Stacks.CreateStack(value).Result;


                Assert.AreEqual("f604c830-eadf-4fd9-9e84-a2675261ddb2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/1e68f561-7ada-4861-b308-c2026e2bf530", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example_stack", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("Description for the example stack", TestUtil.ToTestableString(obj.Description), true);

            }
        }

        [TestMethod]
        public void DeleteStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Stacks.DeleteStack(guid).Wait();

            }
        }

    }
}