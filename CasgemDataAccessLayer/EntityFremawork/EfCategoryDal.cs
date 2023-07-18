using CasgemDataAccessLayer.Abstract;
using CasgemDataAccessLayer.Concrete;
using CasgemDataAccessLayer.Concrete.Repositories;
using CasgemEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemDataAccessLayer.EntityFremawork
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
