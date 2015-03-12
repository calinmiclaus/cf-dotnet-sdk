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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// Apps Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class AppsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractAppsEndpoint
    {
        internal AppsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Apps Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractAppsEndpoint : BaseEndpoint
    {

        /// <summary>
        /// Remove Route from the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/remove_route_from_the_app.html"</para>
        /// </summary>
        public async Task<RemoveRouteFromAppResponse> RemoveRouteFromApp(Guid? guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/routes/{1}", guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveRouteFromAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Route with the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/associate_route_with_the_app.html"</para>
        /// </summary>
        public async Task<AssociateRouteWithAppResponse> AssociateRouteWithApp(Guid? guid, Guid? route_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/routes/{1}", guid, route_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateRouteWithAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Service Binding from the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/remove_service_binding_from_the_app.html"</para>
        /// </summary>
        public async Task<RemoveServiceBindingFromAppResponse> RemoveServiceBindingFromApp(Guid? guid, Guid? service_binding_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/service_bindings/{1}", guid, service_binding_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveServiceBindingFromAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get detailed stats for a STARTED App
        /// <para>Get status for each instance of an App using the app guid.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/get_detailed_stats_for_a_started_app.html"</para>
        /// </summary>
        public async Task<Dictionary<int?, GetDetailedStatsForStartedAppResponse>> GetDetailedStatsForStartedApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/stats", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<Dictionary<int?, GetDetailedStatsForStartedAppResponse>>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Copy the app bits for an App
        /// <para>This endpoint will copy the package bits in the blobstore from the source app to the destination app.</para>
        /// <para>It will always return a job which you can query for success or failure.</para>
        /// <para>This operation will require the app to restart in order for the changes to take effect.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/copy_the_app_bits_for_an_app.html"</para>
        /// </summary>
        public async Task<CopyAppBitsForAppResponse> CopyAppBitsForApp(Guid? guid, CopyAppBitsForAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/copy_bits", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CopyAppBitsForAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/list_all_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsResponse>> ListAllApps()
        {
            return await ListAllApps(new RequestOptions());
        }

        /// <summary>
        /// List all Apps
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/list_all_apps.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsResponse>> ListAllApps(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/apps";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllAppsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/retrieve_a_particular_app.html"</para>
        /// </summary>
        public async Task<RetrieveAppResponse> RetrieveApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Terminate the running App Instance at the given index
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/terminate_the_running_app_instance_at_the_given_index.html"</para>
        /// </summary>
        public async Task TerminateRunningAppInstanceAtGivenIndex(Guid? guid, int? index)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/instances/{1}", guid, index);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Creating an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/creating_an_app.html"</para>
        /// </summary>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/apps";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Updating an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/updating_an_app.html"</para>
        /// </summary>
        public async Task<UpdateAppResponse> UpdateApp(Guid? guid, UpdateAppRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the instance information for a STARTED App
        /// <para>Get status for each instance of an App using the app guid.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/get_the_instance_information_for_a_started_app.html"</para>
        /// </summary>
        public async Task<Dictionary<int?, GetInstanceInformationForStartedAppResponse>> GetInstanceInformationForStartedApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/instances", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<Dictionary<int?, GetInstanceInformationForStartedAppResponse>>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get the env for an App
        /// <para>Get the environment variables for an App using the app guid. Restricted to SpaceDeveloper role.</para>
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/get_the_env_for_an_app.html"</para>
        /// </summary>
        public async Task<GetEnvForAppResponse> GetEnvForApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/env", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetEnvForAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Docker App (experimental)
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/creating_a_docker_app_(experimental).html"</para>
        /// </summary>
        public async Task<CreateDockerAppExperimentalResponse> CreateDockerAppExperimental(CreateDockerAppExperimentalRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/apps";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateDockerAppExperimentalResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Routes for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/list_all_routes_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForAppResponse>> ListAllRoutesForApp(Guid? guid)
        {
            return await ListAllRoutesForApp(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Routes for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/list_all_routes_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForAppResponse>> ListAllRoutesForApp(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/routes", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllRoutesForAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Service Bindings for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/list_all_service_bindings_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForAppResponse>> ListAllServiceBindingsForApp(Guid? guid)
        {
            return await ListAllServiceBindingsForApp(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Service Bindings for the App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/list_all_service_bindings_for_the_app.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceBindingsForAppResponse>> ListAllServiceBindingsForApp(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/service_bindings", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServiceBindingsForAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get App summary
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/get_app_summary.html"</para>
        /// </summary>
        public async Task<GetAppSummaryResponse> GetAppSummary(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/summary", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetAppSummaryResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Restage an App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/restage_an_app.html"</para>
        /// </summary>
        public async Task<RestageAppResponse> RestageApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/restage", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RestageAppResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular App
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/apps/delete_a_particular_app.html"</para>
        /// </summary>
        public async Task DeleteApp(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}