﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace api.Models
{
    public class Certificate : MetadataModelBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("ValidFrom")]
        public DateTime ValidFrom { get; set; }

        [BsonElement("ValidThrough")]
        public DateTime ValidThrough { get; set; }

        [BsonElement("Thumbprint")]
        public string Thumbprint { get; set; }
    }
}