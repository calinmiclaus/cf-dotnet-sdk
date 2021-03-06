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
    public class BlobstoresEndpoint
{
        [TestMethod]
        public void DeleteAllBlobsInBuildpackCacheBlobstoreTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""822b7a23-5959-4457-b172-c13bb11798a9"",
    ""created_at"": ""2016-05-05T14:15:13Z"",
    ""url"": ""/v2/jobs/6c8182b2-7655-4e5f-b4b2-30b6fe0fe857""
  },
  ""entity"": {
    ""guid"": ""822b7a23-5959-4457-b172-c13bb11798a9"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)202;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Blobstores.DeleteAllBlobsInBuildpackCacheBlobstore().Result;


                Assert.AreEqual("822b7a23-5959-4457-b172-c13bb11798a9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-05-05T14:15:13Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/6c8182b2-7655-4e5f-b4b2-30b6fe0fe857", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("822b7a23-5959-4457-b172-c13bb11798a9", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

    }
}