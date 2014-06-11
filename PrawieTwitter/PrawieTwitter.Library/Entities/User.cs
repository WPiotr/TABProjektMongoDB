namespace PrawieTwitter.Library.Entities
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using MongoDB.Driver.Builders;
    using MongoDB.Driver.GridFS;
    using MongoDB.Driver.Linq;

    public class User
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }

    }
}
