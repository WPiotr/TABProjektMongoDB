namespace PrawieTwitter.Library.Controllers
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using MongoDB.Driver;
    using MongoDB.Driver.Linq;
    using MongoDB.Bson;
    using PrawieTwitter.Library.Entities;
    using MongoDB.Driver.Builders;


    public class StatusController : MongoController
    {
        private static MongoCollection collection = database.GetCollection<Status>("Status");
        #region methods

        public static WriteConcernResult Add(Status status)
        {
            return collection.Insert(status);
        }

        public static WriteConcernResult Remove(ObjectId id)
        {
            var query = Query<Status>.EQ(e => e.Id, id);
            return collection.Remove(query);
        }

        public static Status FindById(ObjectId id)
        {
            var query = from e in collection.AsQueryable<Status>()
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

        public static List<Status> FindByUser(ObjectId userId) 
        {
            var query = from e in collection.AsQueryable<Status>()
                        where e.UserId == userId
                        select e;
            
            return new List<Status>(query);
        }

        public static WriteConcernResult Update(User user) {
            return collection.Save(user);
        }

        #endregion

    }
}
