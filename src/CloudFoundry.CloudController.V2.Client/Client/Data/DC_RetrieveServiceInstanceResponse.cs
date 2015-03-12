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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.RetrieveServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_instances/retrieve_a_particular_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveServiceInstanceResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveServiceInstanceResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.RetrieveServiceInstance()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/service_instances/retrieve_a_particular_service_instance.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveServiceInstanceResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Credentials</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plan Guid</para>
        /// </summary>
        [JsonProperty("service_plan_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicePlanGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Gateway Data</para>
        /// </summary>
        [JsonProperty("gateway_data", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic GatewayData
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Dashboard Url</para>
        /// </summary>
        [JsonProperty("dashboard_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DashboardUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Url</para>
        /// </summary>
        [JsonProperty("space_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Plan Url</para>
        /// </summary>
        [JsonProperty("service_plan_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlanUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Bindings Url</para>
        /// </summary>
        [JsonProperty("service_bindings_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceBindingsUrl
        {
            get;
            set;
        }
    }
}