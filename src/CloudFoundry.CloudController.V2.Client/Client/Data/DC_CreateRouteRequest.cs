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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.RoutesEndpoint.CreateRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/routes/creating_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateRouteRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateRouteRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.RoutesEndpoint.CreateRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/routes/creating_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateRouteRequest
    {

        /// <summary> 
        /// <para>The guid of the associated domain</para>
        /// </summary>
        [JsonProperty("domain_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DomainGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the associated space</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the route.</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The host portion of the route</para>
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Host
        {
            get;
            set;
        }
    }
}