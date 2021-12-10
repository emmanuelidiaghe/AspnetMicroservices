using MongoDB.Driver;
using Catalog.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.api.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Products> Products { get; } 
    }
}
