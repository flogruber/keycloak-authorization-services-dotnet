// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    #pragma warning disable CS1591
    public class RoleRepresentation : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RoleRepresentation_attributes? Attributes { get; set; }
#nullable restore
#else
        public RoleRepresentation_attributes Attributes { get; set; }
#endif
        /// <summary>The clientRole property</summary>
        public bool? ClientRole { get; set; }
        /// <summary>The composite property</summary>
        public bool? Composite { get; set; }
        /// <summary>The composites property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Models.Composites? Composites { get; set; }
#nullable restore
#else
        public Keycloak.AuthServices.Sdk.Kiota.Admin.Models.Composites Composites { get; set; }
#endif
        /// <summary>The containerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerId { get; set; }
#nullable restore
#else
        public string ContainerId { get; set; }
#endif
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
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The scopeParamRequired property</summary>
        [Obsolete("")]
        public bool? ScopeParamRequired { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RoleRepresentation"/> and sets the default values.
        /// </summary>
        public RoleRepresentation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RoleRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RoleRepresentation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attributes", n => { Attributes = n.GetObjectValue<RoleRepresentation_attributes>(RoleRepresentation_attributes.CreateFromDiscriminatorValue); } },
                {"clientRole", n => { ClientRole = n.GetBoolValue(); } },
                {"composite", n => { Composite = n.GetBoolValue(); } },
                {"composites", n => { Composites = n.GetObjectValue<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.Composites>(Keycloak.AuthServices.Sdk.Kiota.Admin.Models.Composites.CreateFromDiscriminatorValue); } },
                {"containerId", n => { ContainerId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scopeParamRequired", n => { ScopeParamRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RoleRepresentation_attributes>("attributes", Attributes);
            writer.WriteBoolValue("clientRole", ClientRole);
            writer.WriteBoolValue("composite", Composite);
            writer.WriteObjectValue<Keycloak.AuthServices.Sdk.Kiota.Admin.Models.Composites>("composites", Composites);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("scopeParamRequired", ScopeParamRequired);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
