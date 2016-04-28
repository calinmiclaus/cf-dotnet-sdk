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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlansEndpoint.UpdateServicePlanDeprecated()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/236/service_plans/updating_a_service_plan_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateServicePlanDeprecatedRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateServicePlanDeprecatedRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicePlansEndpoint.UpdateServicePlanDeprecated()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/236/service_plans/updating_a_service_plan_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateServicePlanDeprecatedRequest
    {

        /// <summary> 
        /// <para>The name of the service plan</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A boolean describing if the service plan is free</para>
        /// </summary>
        [JsonProperty("free", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Free
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A description of the service plan</para>
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the related service</para>
        /// </summary>
        [JsonProperty("service_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the service plan</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A JSON string with additional data about the plan</para>
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public string Extra
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A guid for the service plan in the service broker (not the same as the cloud controller guid)</para>
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic UniqueId
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A boolean describing that the plan is visible to the all users</para>
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Public
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A boolean that determines whether plans can be used to create new instances.</para>
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active
        {
            get;
            set;
        }
    }
}