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

        public void Add()
        {
            Console.WriteLine("Create");
        }

        public void Get()
        {
            Console.WriteLine("Read");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
        }
    }
    }
}
