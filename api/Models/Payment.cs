using MongoDB.Bson.Serialization.Attributes;
using System;

namespace api.Models
{
    public class Payment
    {
        [BsonElement("PaymentDate")]
        public DateTime PaymentDate { get; set; }
        [BsonElement("Amount")]
        public float Amount { get; set; }
        [BsonElement("StripeReference")]
        public string StripeReference { get; set; }
        [BsonElement("SubscriptionReference")]
        public string SubscriptionReference { get; set; }
        [BsonElement("PaymentType")]
        public PaymentType PaymentType { get; set; }
        [BsonElement("PaymentStatus")]
        public PaymentStatus PaymentStatus { get; set; }
    }

    public enum PaymentType
    {
        CREDIT,
        DEBIT,
        UNKNOWN
    }

    public enum PaymentStatus
    {
        Paid = 1,
        Cancelled = 2,
        Refunded = 4,
        Rejected = 8,
        InProcess = 16
    }
}
