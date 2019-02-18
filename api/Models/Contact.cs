using MongoDB.Bson.Serialization.Attributes;

namespace api.Models
{
    public class Contact
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Address")]
        public string Address { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("PostalCode")]
        public string PostalCode { get; set; }
        [BsonElement("Country")]
        public string Country { get; set; }
    }
}
