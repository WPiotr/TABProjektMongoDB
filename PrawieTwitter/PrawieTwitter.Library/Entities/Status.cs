namespace PrawieTwitter.Library.Entities
{   
    using MongoDB.Bson;
    using MongoDB.Driver;
    public class Status
    {
        public ObjectId Id { get; set; }
        public string Text { get; set; }
        public BsonDateTime Date { get; set; }
        public ObjectId UserId { get; set; }

    }
}
