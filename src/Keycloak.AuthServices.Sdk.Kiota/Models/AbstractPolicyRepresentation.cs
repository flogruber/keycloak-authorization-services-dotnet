// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    #pragma warning disable CS1591
    public class AbstractPolicyRepresentation : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The decisionStrategy property</summary>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Models.DecisionStrategy? DecisionStrategy { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The logic property</summary>
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Models.Logic? Logic { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner { get; set; }
#nullable restore
#else
        public string Owner { get; set; }
#endif
        /// <summary>The policies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Policies { get; set; }
#nullable restore
#else
        public List<string> Policies { get; set; }
#endif
        /// <summary>The resources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Resources { get; set; }
#nullable restore
#else
        public List<string> Resources { get; set; }
#endif
        /// <summary>The resourcesData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceRepresentation>? ResourcesData { get; set; }
#nullable restore
#else
        public List<ResourceRepresentation> ResourcesData { get; set; }
#endif
        /// <summary>The scopes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Scopes { get; set; }
#nullable restore
#else
        public List<string> Scopes { get; set; }
#endif
        /// <summary>The scopesData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScopeRepresentation>? ScopesData { get; set; }
#nullable restore
#else
        public List<ScopeRepresentation> ScopesData { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AbstractPolicyRepresentation"/> and sets the default values.
        /// </summary>
        public AbstractPolicyRepresentation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AbstractPolicyRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AbstractPolicyRepresentation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AbstractPolicyRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"decisionStrategy", n => { DecisionStrategy = n.GetEnumValue<DecisionStrategy>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"logic", n => { Logic = n.GetEnumValue<Logic>(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"policies", n => { Policies = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"resources", n => { Resources = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"resourcesData", n => { ResourcesData = n.GetCollectionOfObjectValues<ResourceRepresentation>(ResourceRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scopes", n => { Scopes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"scopesData", n => { ScopesData = n.GetCollectionOfObjectValues<ScopeRepresentation>(ScopeRepresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DecisionStrategy>("decisionStrategy", DecisionStrategy);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<Logic>("logic", Logic);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfPrimitiveValues<string>("policies", Policies);
            writer.WriteCollectionOfPrimitiveValues<string>("resources", Resources);
            writer.WriteCollectionOfObjectValues<ResourceRepresentation>("resourcesData", ResourcesData);
            writer.WriteCollectionOfPrimitiveValues<string>("scopes", Scopes);
            writer.WriteCollectionOfObjectValues<ScopeRepresentation>("scopesData", ScopesData);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
