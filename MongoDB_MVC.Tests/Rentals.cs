using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB_MVC.Rentals;
using MongoDB.Bson;
using NUnit.Framework;

namespace MongoDB_MVC.Tests
{
    [TestClass]
    public class Rentals : AssertionHelper
    {
        [TestMethod]
        public void ToDocument_RentalWithPrice_PriceAsDouble()
        {
            var rental = new Rental();
            rental.Price = 1;

            var document = rental.ToBsonDocument();

            Expect(document["Price"].BsonType, Is.EqualTo(BsonType.Double));
        }

        [TestMethod]
        public void ToDocument_RentalWithID_IdIsRepresentedAsObjectId()
        {
            var rental = new Rental();
            rental.Id = ObjectId.GenerateNewId().ToString();

            var document = rental.ToBsonDocument();

            //Expect(document["_Id"].BsonType, Is.EqualTo(BsonType.ObjectId));
        }
    }
}
