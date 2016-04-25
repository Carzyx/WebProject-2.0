using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infraestructura
{
    public interface IUnitOfWork:IDisposable
    {
<<<<<<< HEAD
        int SaveChanges();
        
=======
        public int SaveChanges { get; set; }
>>>>>>> 00df84565907ad3aeed5fae44b01518f8eef28c8
    }
}
