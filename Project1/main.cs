using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Project1
{
    class main
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://mongodb.test.local:27017");
            Sample test = new Sample { name = "Rob", description = "de beste" };
            MongoDatabase database = client.GetServer().GetDatabase("blgg");
            database.GetCollection("samples").Insert(test);
        }
    }
}
