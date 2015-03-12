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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationQuotaDefinitionsEndpoint.UpdateOrganizationQuotaDefinition()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/organization_quota_definitions/updating_a_organization_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateOrganizationQuotaDefinitionRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateOrganizationQuotaDefinitionRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationQuotaDefinitionsEndpoint.UpdateOrganizationQuotaDefinition()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/organization_quota_definitions/updating_a_organization_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateOrganizationQuotaDefinitionRequest
    {

        /// <summary> 
        /// <para>The name for the Organization Quota Definition.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If an organization can have non basic services</para>
        /// </summary>
        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many services an organization can have.</para>
        /// </summary>
        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalServices
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many routes an organization can have.</para>
        /// </summary>
        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRoutes
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How much memory in megabyte an organization can have.</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The maximum amount of memory in megabyte an application instance can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If an organization can have a trial db.</para>
        /// </summary>
        [JsonProperty("trial_db_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TrialDbAllowed
        {
            get;
            set;
        }
    }
}