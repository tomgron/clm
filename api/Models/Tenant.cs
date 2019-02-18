using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace api.Models
{
    public class Tenant : MetadataModelBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("PrimaryContact")]
        public Contact PrimaryContact { get; set; }

        [BsonElement("Subscriptions")]
        public string[] Subscriptions { get; set; }

        [BsonElement("Payments")]
        public Payment[] Payments { get; set; }
    }
}
