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
    public class JobsTest
    {


        [TestMethod]
        public void TestRetrieveJobThatWasSuccessfulResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""e921deed-a483-4474-bdc5-99bea8209833"",
    ""created_at"": ""1970-01-01T00:00:00Z"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""e921deed-a483-4474-bdc5-99bea8209833"",
    ""status"": ""finished""
  }
}";

            RetrieveJobThatWasSuccessfulResponse obj = Utilities.DeserializeJson<RetrieveJobThatWasSuccessfulResponse>(json);

            Assert.AreEqual("e921deed-a483-4474-bdc5-99bea8209833", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("1970-01-01T00:00:00Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("e921deed-a483-4474-bdc5-99bea8209833", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);
        }

        [TestMethod]
        public void TestRetrieveJobThatIsQueuedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""61f7d632-038c-49b5-972c-682d0b335e95"",
    ""created_at"": ""2016-05-05T14:15:27Z"",
    ""url"": ""/v2/jobs/83c67262-e7c2-41ce-a3b6-c8db79c896b4""
  },
  ""entity"": {
    ""guid"": ""61f7d632-038c-49b5-972c-682d0b335e95"",
    ""status"": ""queued""
  }
}";

            RetrieveJobThatIsQueuedResponse obj = Utilities.DeserializeJson<RetrieveJobThatIsQueuedResponse>(json);

            Assert.AreEqual("61f7d632-038c-49b5-972c-682d0b335e95", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-05-05T14:15:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/83c67262-e7c2-41ce-a3b6-c8db79c896b4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("61f7d632-038c-49b5-972c-682d0b335e95", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);
        }

        [TestMethod]
        public void TestRetrieveJobWithUnknownFailureResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""172a9565-6cff-4737-9a9c-a22a53e8b439"",
    ""created_at"": ""2016-05-05T14:15:27Z"",
    ""url"": ""/v2/jobs/ad8da54a-22cc-4bbe-b6ef-f428dcc45e31""
  },
  ""entity"": {
    ""guid"": ""172a9565-6cff-4737-9a9c-a22a53e8b439"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";

            RetrieveJobWithUnknownFailureResponse obj = Utilities.DeserializeJson<RetrieveJobWithUnknownFailureResponse>(json);

            Assert.AreEqual("172a9565-6cff-4737-9a9c-a22a53e8b439", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-05-05T14:15:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/ad8da54a-22cc-4bbe-b6ef-f428dcc45e31", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("172a9565-6cff-4737-9a9c-a22a53e8b439", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
            Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);
        }

        [TestMethod]
        public void TestRetrieveJobWithKnownFailureResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""aed80185-101b-4fe1-8398-484225dfb236"",
    ""created_at"": ""2016-05-05T14:15:27Z"",
    ""url"": ""/v2/jobs/166d4996-4ae5-450b-bfa5-80def7559587""
  },
  ""entity"": {
    ""guid"": ""aed80185-101b-4fe1-8398-484225dfb236"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";

            RetrieveJobWithKnownFailureResponse obj = Utilities.DeserializeJson<RetrieveJobWithKnownFailureResponse>(json);

            Assert.AreEqual("aed80185-101b-4fe1-8398-484225dfb236", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-05-05T14:15:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/166d4996-4ae5-450b-bfa5-80def7559587", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("aed80185-101b-4fe1-8398-484225dfb236", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
            Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);
        }
    }
}
