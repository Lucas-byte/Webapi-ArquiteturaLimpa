using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
