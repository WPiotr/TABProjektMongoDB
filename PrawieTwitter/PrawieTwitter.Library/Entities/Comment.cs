namespace PrawieTwitter.Library.Entities
{
    using MongoDB.Bson;
    public class Comment
    {
        public ObjectId Id { get; set; }
        public int CommentId { get; set; }
        public BsonDateTime Date { get; set; }
        public string Text { get; set; }
        public ObjectId UserId { get; set; }
        public ObjectId StatusId { get; set; }
    }
}
