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
    public class BuildpacksEndpoint
{
        [TestMethod]
        public void ChangePositionOfBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""b6e837bd-e121-497f-a317-d13d4e9395fb"",
    ""url"": ""/v2/buildpacks/b6e837bd-e121-497f-a317-d13d4e9395fb"",
    ""created_at"": ""2015-04-10T20:04:25+00:00"",
    ""updated_at"": ""2015-04-10T20:04:25+00:00""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 3,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-321""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                ChangePositionOfBuildpackRequest value = new ChangePositionOfBuildpackRequest();


                var obj = cfClient.Buildpacks.ChangePositionOfBuildpack(guid, value).Result;


                Assert.AreEqual("b6e837bd-e121-497f-a317-d13d4e9395fb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/b6e837bd-e121-497f-a317-d13d4e9395fb", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-321", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void LockOrUnlockBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""2c23bad2-7d9f-48ee-a90c-cd903f8157d3"",
    ""url"": ""/v2/buildpacks/2c23bad2-7d9f-48ee-a90c-cd903f8157d3"",
    ""created_at"": ""2015-04-10T20:04:25+00:00"",
    ""updated_at"": ""2015-04-10T20:04:26+00:00""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": true,
    ""filename"": ""name-327""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                LockOrUnlockBuildpackRequest value = new LockOrUnlockBuildpackRequest();


                var obj = cfClient.Buildpacks.LockOrUnlockBuildpack(guid, value).Result;


                Assert.AreEqual("2c23bad2-7d9f-48ee-a90c-cd903f8157d3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/2c23bad2-7d9f-48ee-a90c-cd903f8157d3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T20:04:26+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-327", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void EnableOrDisableBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""30e1239e-138e-4a68-82fb-01eed77912d6"",
    ""url"": ""/v2/buildpacks/30e1239e-138e-4a68-82fb-01eed77912d6"",
    ""created_at"": ""2015-04-10T20:04:25+00:00"",
    ""updated_at"": ""2015-04-10T20:04:25+00:00""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": false,
    ""locked"": false,
    ""filename"": ""name-324""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                EnableOrDisableBuildpackRequest value = new EnableOrDisableBuildpackRequest();


                var obj = cfClient.Buildpacks.EnableOrDisableBuildpack(guid, value).Result;


                Assert.AreEqual("30e1239e-138e-4a68-82fb-01eed77912d6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/30e1239e-138e-4a68-82fb-01eed77912d6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-324", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void RetrieveBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e35f1a60-d3eb-492c-bd87-3859aba6464a"",
    ""url"": ""/v2/buildpacks/e35f1a60-d3eb-492c-bd87-3859aba6464a"",
    ""created_at"": ""2015-04-10T20:04:25+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-318""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Buildpacks.RetrieveBuildpack(guid).Result;


                Assert.AreEqual("e35f1a60-d3eb-492c-bd87-3859aba6464a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/e35f1a60-d3eb-492c-bd87-3859aba6464a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("name-318", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void CreatesAdminBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""0d31fa61-d6c5-4b53-906f-7cb8dd802cfd"",
    ""url"": ""/v2/buildpacks/0d31fa61-d6c5-4b53-906f-7cb8dd802cfd"",
    ""created_at"": ""2015-04-10T20:04:26+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""Golang_buildpack"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreatesAdminBuildpackRequest value = new CreatesAdminBuildpackRequest();


                var obj = cfClient.Buildpacks.CreatesAdminBuildpack(value).Result;


                Assert.AreEqual("0d31fa61-d6c5-4b53-906f-7cb8dd802cfd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/0d31fa61-d6c5-4b53-906f-7cb8dd802cfd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:26+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("Golang_buildpack", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Filename), true);

            }
        }

        [TestMethod]
        public void ListAllBuildpacksTest()
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
        ""guid"": ""d6282246-a73d-4b59-b240-b8b7b3081ddf"",
        ""url"": ""/v2/buildpacks/d6282246-a73d-4b59-b240-b8b7b3081ddf"",
        ""created_at"": ""2015-04-10T20:04:25+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_1"",
        ""position"": 1,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-315""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5f6aaa69-fc62-4103-b65d-9e5f5c66229e"",
        ""url"": ""/v2/buildpacks/5f6aaa69-fc62-4103-b65d-9e5f5c66229e"",
        ""created_at"": ""2015-04-10T20:04:25+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_2"",
        ""position"": 2,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-316""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""1671b2ad-8d87-4844-9fb1-7e700644c27b"",
        ""url"": ""/v2/buildpacks/1671b2ad-8d87-4844-9fb1-7e700644c27b"",
        ""created_at"": ""2015-04-10T20:04:25+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_3"",
        ""position"": 3,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-317""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Buildpacks.ListAllBuildpacks().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("d6282246-a73d-4b59-b240-b8b7b3081ddf", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/d6282246-a73d-4b59-b240-b8b7b3081ddf", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_1", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Locked), true);
                Assert.AreEqual("name-315", TestUtil.ToTestableString(obj[0].Filename), true);
                Assert.AreEqual("5f6aaa69-fc62-4103-b65d-9e5f5c66229e", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/5f6aaa69-fc62-4103-b65d-9e5f5c66229e", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_2", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj[1].Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[1].Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].Locked), true);
                Assert.AreEqual("name-316", TestUtil.ToTestableString(obj[1].Filename), true);
                Assert.AreEqual("1671b2ad-8d87-4844-9fb1-7e700644c27b", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/buildpacks/1671b2ad-8d87-4844-9fb1-7e700644c27b", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:25+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name_3", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("3", TestUtil.ToTestableString(obj[2].Position), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[2].Enabled), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].Locked), true);
                Assert.AreEqual("name-317", TestUtil.ToTestableString(obj[2].Filename), true);

            }
        }

        [TestMethod]
        public void DeleteBuildpackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Buildpacks.DeleteBuildpack(guid).Wait();

            }
        }

    }
}