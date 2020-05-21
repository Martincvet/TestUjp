using Core;
using Data.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Data.Sql
{
    public class ProductRepository : IProductRepository
    {
        private readonly UjpDbContext ujpDbContext;

        public ProductRepository(UjpDbContext ujpDbContext)
        {
            this.ujpDbContext = ujpDbContext;
        }

        public int Commit()
        {
            return ujpDbContext.SaveChanges();
        }

        public Product Create(Product product)
        {
            ujpDbContext.Products.Add(product);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return ujpDbContext.Products.ToList();
        }
    }
}
