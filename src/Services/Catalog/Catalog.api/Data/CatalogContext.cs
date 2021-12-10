using Catalog.api.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Catalog.api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.api.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)

        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Products>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogContextSeedData.SeedData(Products);
        }
        public IMongoCollection<Products> Products { get; }
    }
}
