namespace PrawieTwitter.Library.Controllers
{
    using MongoDB.Driver;
    using PrawieTwitter.Library.Entities;

    public abstract class MongoController
    {
        #region fields
        private static MongoClient client = new MongoClient("mongodb://localhost");
        private static MongoServer server = client.GetServer();
        protected static MongoDatabase database = server.GetDatabase("prawieTwitter");
        #endregion
    }
}
