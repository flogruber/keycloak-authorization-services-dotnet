// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.ImportConfig;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Instances;
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider.Providers;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.IdentityProvider {
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\identity-provider
    /// </summary>
    public class IdentityProviderRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The importConfig property</summary>
        public ImportConfigRequestBuilder ImportConfig
        {
            get => new ImportConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The instances property</summary>
        public InstancesRequestBuilder Instances
        {
            get => new InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The providers property</summary>
        public ProvidersRequestBuilder Providers
        {
            get => new ProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="IdentityProviderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/identity-provider", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IdentityProviderRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityProviderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/identity-provider", rawUrl)
        {
        }
    }
}
