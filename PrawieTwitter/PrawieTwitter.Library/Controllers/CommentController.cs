namespace PrawieTwitter.Library.Controllers
{
    using System;
    using System.Linq;
    using MongoDB.Driver;
    using MongoDB.Driver.Linq;
    using PrawieTwitter.Library.Entities;
    using System.Collections.Generic;
    using MongoDB.Bson;
    using MongoDB.Driver.Builders;

    public class CommentController : MongoController
    {
        private static MongoCollection collection = database.GetCollection<Comment>("Comments");
        public static WriteConcernResult Add(Comment status)
        {
            return collection.Insert(status);
        }

        public static Comment FindById(ObjectId id)
        {
            var query = from e in collection.AsQueryable<Comment>()
                        where e.Id == id
                        select e;
            if (query.Count() == 0)
            {
                return null;
            }
            else
            {
                return query.First();
            }
        }

        public static List<Comment> FindByUser(ObjectId userId)
        {
            var query = from e in collection.AsQueryable<Comment>()
                        where e.UserId == userId
                        select e;
            return new List<Comment>(query.ToList());
        }

        public static List<Comment> FindByStatus(ObjectId statusId)
        {
            var query = from e in collection.AsQueryable<Comment>()
                        where e.StatusId == statusId
                        select e;
            return new List<Comment>(query.ToList());
        }

        public static WriteConcernResult Remove(ObjectId id) {
            var query = Query<Comment>.EQ(e => e.Id, id);
            return collection.Remove(query);
        }

        public static WriteConcernResult Update(Comment comment) {
            return collection.Save(comment);
        }
    }
}
