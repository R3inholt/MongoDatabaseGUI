using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDatabase.MongoDB
{
    static class MongoConnection
    {
        public static IMongoDatabase Establish()
        {
            MongoClient _client = new MongoClient();

            return _client.GetDatabase("moviesDatabase");
        }
    }
}
