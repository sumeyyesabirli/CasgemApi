using CasgemEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemBusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetProductsWithCategories();
    }
}
