using MongoDB.Driver;
using MongoDB_MVC.Properties;
using MongoDB_MVC.Rentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_MVC.App_Start
{
    public class RealEstateContext
    {
        public MongoDatabase Database;
        public RealEstateContext()
        {
            var client = new MongoClient(Settings.Default.RealEstateConectString);
            var server = client.GetServer();
            Database = server.GetDatabase(Settings.Default.RealEstateDB);
        }

        public MongoCollection<Rental> Rentals
        {
            get
            {
                return Database.GetCollection<Rental>("rentals");
            }
        }
    }
}
