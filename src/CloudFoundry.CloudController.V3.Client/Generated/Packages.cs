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
using CloudFoundry.CloudController.V3.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client
{
    /// <summary>
    /// Packages Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class PackagesEndpoint : CloudFoundry.CloudController.V3.Client.Base.AbstractPackagesEndpoint
    {
        internal PackagesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V3.Client.Base
{
    /// <summary>
    /// Base abstract class for Packages Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractPackagesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractPackagesEndpoint()
        {
        }

        /// <summary>
        /// Get a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/packages__experimental_/get_a_package.html"</para>
        /// </summary>
        public async Task<GetPackageResponse> GetPackage(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/packages/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<GetPackageResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Create a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/packages__experimental_/create_a_package.html"</para>
        /// </summary>
        public async Task<CreatePackageResponse> CreatePackage(Guid? guid, CreatePackageRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/apps/{0}/packages", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreatePackageResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Stage a package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/packages__experimental_/stage_a_package.html"</para>
        /// </summary>
        public async Task<StagePackageResponse> StagePackage(Guid? guid, StagePackageRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/packages/{0}/droplets", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<StagePackageResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Package
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/packages__experimental_/delete_a_package.html"</para>
        /// </summary>
        public async Task DeletePackage(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v3/packages/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Packages
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/packages__experimental_/list_all_packages.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPackagesResponse>> ListAllPackages()
        {
            return await ListAllPackages(new RequestOptions());
        }

        /// <summary>
        /// List all Packages
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/195/packages__experimental_/list_all_packages.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllPackagesResponse>> ListAllPackages(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v3/packages";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllPackagesResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }
    }
}