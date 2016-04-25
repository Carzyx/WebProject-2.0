using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infraestructura
{
    public class AppContext : DbContext, IUnitOfWork, IRepositoryCustomer
    {
       public AppContext()
       {

       }
       
       public IDbSet<Customer> Customer { get; set; }
    }
}
