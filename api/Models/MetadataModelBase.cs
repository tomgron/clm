using MongoDB.Bson.Serialization.Attributes;
using System;

namespace api.Models
{
    public abstract class MetadataModelBase : ModelBase
    {
        [BsonElement("Tags")]
        public string[] Tags { get; set; }
        [BsonElement("Created")]
        public DateTime Created { get; set; }
        [BsonElement("Modified")]
        public DateTime Modified { get; set; }
        [BsonElement("CreatedBy")]
        public string CreatedBy { get; set; }
        [BsonElement("ModifiedBy")]
        public string ModifiedBy { get; set; }
        [BsonElement("MustBeDeletedAfter")]
        public DateTime? MustBeDeletedAfter { get; set; }
    }
}
