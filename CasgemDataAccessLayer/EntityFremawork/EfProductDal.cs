using CasgemDataAccessLayer.Abstract;
using CasgemDataAccessLayer.Concrete;
using CasgemDataAccessLayer.Concrete.Repositories;
using CasgemEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemDataAccessLayer.EntityFremawork
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            using var context= new Context();
            return context.Products.Include(x=>x.Category).ToList();
        }
    }
}
