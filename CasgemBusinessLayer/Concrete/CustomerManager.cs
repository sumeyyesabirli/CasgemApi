using CasgemBusinessLayer.Abstract;
using CasgemDataAccessLayer.Abstract;
using CasgemEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemBusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
