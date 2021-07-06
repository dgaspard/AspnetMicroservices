using AspnetRunBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRunBasics.Services
{
    public interface ICatalogService
    {
        Task<CatalogModel> GetCatalog(string id);
        Task<IEnumerable<CatalogModel>> GetCatalog();
        Task<IEnumerable<CatalogModel>> GetCatalogByCategory(String category);
        Task<CatalogModel> CreateCatalog(CatalogModel model); 
    }
}
