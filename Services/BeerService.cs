using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeersApi.Models;
using MongoDB.Driver;

namespace BeersApi.Services
{
    public class BeerService
    {
        private readonly IMongoCollection<Beers> _beers;

        public BeerService(IBeerDatabaseSettings settings) 
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
             
            _beers = database.GetCollection<Beers>(settings.BeerCollectionName);
        }

        public List<Beers> Get() =>
            _beers.Find(beer => true).ToList();

        public Beers Get(string id) =>
            _beers.Find<Beers>(beer => beer.Id == id).FirstOrDefault();

        public Beers Create(Beers beer)
        {
            _beers.InsertOne(beer);
            return beer;
        }

        public void Update(string id, Beers beerIn) =>
            _beers.ReplaceOne(beer => beer.Id == id, beerIn);

        public void Remove(Beers beerIn) =>
            _beers.DeleteOne(beer => beerIn.Id == beerIn.Id);

        public void Remove(string id) =>
            _beers.DeleteOne(beer => beer.Id == id);
       
    }
}
