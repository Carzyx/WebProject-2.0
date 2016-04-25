using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructura;

namespace Services
{
    public interface ICustomerService
    {
        Customer Add(Customer customer);
        void Delete(int id);
        void Update(int id, Customer customer);
        Customer Get(int id);
        IEnumerable<Customer> GetAll(string name);
    }
}
