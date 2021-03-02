using Shop.Domain.Entities;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public AppDbContext _contexto;

        public ProductRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _contexto.Products;
        }
    }
}
