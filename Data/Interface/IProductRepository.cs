using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Create(Product product);
        int Commit();
    }
}
