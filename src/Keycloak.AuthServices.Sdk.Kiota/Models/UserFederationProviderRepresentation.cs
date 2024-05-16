// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    #pragma warning disable CS1591
    public class UserFederationProviderRepresentation : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The changedSyncPeriod property</summary>
        public int? ChangedSyncPeriod { get; set; }
        /// <summary>The config property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserFederationProviderRepresentation_config? Config { get; set; }
#nullable restore
#else
        public UserFederationProviderRepresentation_config Config { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The fullSyncPeriod property</summary>
        public int? FullSyncPeriod { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The lastSync property</summary>
        public int? LastSync { get; set; }
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The providerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderName { get; set; }
#nullable restore
#else
        public string ProviderName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UserFederationProviderRepresentation"/> and sets the default values.
        /// </summary>
        public UserFederationProviderRepresentation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserFederationProviderRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserFederationProviderRepresentation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFederationProviderRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"changedSyncPeriod", n => { ChangedSyncPeriod = n.GetIntValue(); } },
                {"config", n => { Config = n.GetObjectValue<UserFederationProviderRepresentation_config>(UserFederationProviderRepresentation_config.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fullSyncPeriod", n => { FullSyncPeriod = n.GetIntValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"lastSync", n => { LastSync = n.GetIntValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"providerName", n => { ProviderName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("changedSyncPeriod", ChangedSyncPeriod);
            writer.WriteObjectValue<UserFederationProviderRepresentation_config>("config", Config);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("fullSyncPeriod", FullSyncPeriod);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("lastSync", LastSync);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
