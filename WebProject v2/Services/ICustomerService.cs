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
        int Delete(Customer customer);
        int Update(Customer customer);
        Customer Get(int id);
    }
}
