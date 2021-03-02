using Shop.Application.Interfaces;
using Shop.Application.ViewModels;
using Shop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductViewModel GetProducts()
        {
            return new ProductViewModel
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
