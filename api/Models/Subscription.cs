using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.Models
{
    public class Subscription : MetadataModelBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("IsActive")]
        public bool IsActive { get; set; }
        [BsonElement("ValidFrom")]
        public DateTime ValidFrom { get; set; }
        [BsonElement("ValidThrough")]
        public DateTime? ValidThrough { get; set; }
    }
}
