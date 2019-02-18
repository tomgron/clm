using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Linq;

namespace api.Models
{
    public class Subscription : MetadataModelBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("TenantId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TenantId { get; set; }
        [BsonElement("IsActive")]
        public bool IsActive { get; set; }
        [BsonElement("ValidFrom")]
        public DateTime ValidFrom { get; set; }
        [BsonElement("ValidThrough")]
        public DateTime? ValidThrough { get; set; }
    }
}
