using System;
using MongoDB.Driver;
using System.Linq;

using MongoDB.Bson;
using System.Collections.Generic;

namespace rimysoft.Classes
{

    public class LoginDL
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        protected IMongoCollection<User> _collection;

        public LoginDL(){
            try
            {
                _client = new MongoClient(Settings.MongoDBConn);

                _database = _client.GetDatabase("rimysoft");
            }
            catch (Exception ex)
            {
                int t = 0;
            }



        }

        public List<User> Go(){
            _collection = _database.GetCollection<User>("Users");
            var query = _collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
    
        /*
        public PostModel InsertPost(PostModel contact)
        {
            this._collection.InsertOneAsync(contact);
            return this.Get(contact._id.ToString());
        }

        public List<PostModel> SelectAll()
        {
            var query = this._collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public List<PostModel> Filter(string jsonQuery)
        {
            var queryDoc = new QueryDocument(BsonSerializer.Deserialize<BsonDocument>(jsonQuery));
            return _collection.Find<PostModel>(queryDoc).ToList();
        }

        public PostModel Get(string id)
        {
            return this._collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public PostModel UpdatePost(string id, PostModel postmodel)
        {
            postmodel._id = new ObjectId(id);

            var filter = Builders<PostModel>.Filter.Eq(s => s._id, postmodel._id);
            this._collection.ReplaceOneAsync(filter, postmodel);
            return this.Get(id);
        }
        */
    
    }




    public class User
    {
        public User()
        {
            
        }

        public string Username
        {
            get;
            set;
        }

        public ObjectId _id
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool isLogged
        {
            get;
            set;
     
        
        
        
        }

    }
}
