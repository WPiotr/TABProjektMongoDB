namespace PrawieTwitter.Library.Controllers
{
    using System.Linq;
    using MongoDB.Bson;
    using MongoDB.Driver;
    using MongoDB.Driver.Linq;
    using Entities;
    using MongoDB.Driver.Builders;
    using System;
    using System.Collections.Generic;
    public class UserController : MongoController
    {
        private static MongoCollection collection = database.GetCollection<User>("Users");

        #region methods
        public static void Add(User u)
        {
            var query = from e in collection.AsQueryable<User>()
                        where e.Email == u.Email
                        select e;
            if (query.Count() != 0)
            {
                throw new Exception("Jest juz konto z tym adresem email!");
            }
            else
            {
                collection.Insert(u);
            }
        }

        public static User FindById(ObjectId id)
        {
            var query = from e in collection.AsQueryable<User>()
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

        public static User FindByEmail(string email)
        {
            var query = from e in collection.AsQueryable<User>()
                        where e.Email == email
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

        public static List<User> FindByNames(string firstName, string lastName) 
        {
            var query = from e in collection.AsQueryable<User>()
                        where e.FirstName == firstName && e.LastName == lastName
                        select e;
            return new List<User>(query);
        
        }

        public static User Login(string email, string password)
        {
            var query = from e in collection.AsQueryable<User>()
                        where e.Email == email && e.Password == password
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

        public static WriteConcernResult Remove(ObjectId id)
        {
            var query = Query<User>.EQ(e => e.Id, id);
            return collection.Remove(query);
        }

        public static WriteConcernResult Update(User user)
        {
            return collection.Save(user);
        }
        #endregion
    }
}