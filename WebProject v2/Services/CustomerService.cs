using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructura;

namespace Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        readonly IRepositoryCustomer _repository;

        public CustomerService(IRepositoryCustomer repository)
            :base(repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }

        public IEnumerable<Customer> GetAll(string name)
        {
            return _repository.Customers.Where(c => c.Name.Contains(name));
        }

        public Customer Add(Customer customer)
        {
            var customernew = _repository.Customers.Add(customer);
            SaveChanges();
            return customernew;
        }

        public Customer Get(int id)
        {
            return GetCustomer(id);
        }

        public void Update(int id, Customer customer)
        {
            var customerOld = GetCustomer(id);
            CheckNullCustomer(customerOld);
            UpdateCustomer(customer, customerOld);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = GetCustomer(id);
            CheckNullCustomer(customer);
            _repository.Customers.Remove(customer);
            SaveChanges();   
        }

        private static void UpdateCustomer(Customer customer, Customer customerOld)
        {
            customerOld.Name = customer.Name;
            customerOld.Phone = customer.Phone;
        }

        private static void CheckNullCustomer(Customer customer)
        {
            if(null==customer)
            {
                throw new NullReferenceException("El cliente no existe");
            }
        }

        private Customer GetCustomer(int id)
        {
            return _repository.Customers.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
