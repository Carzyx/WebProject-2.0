using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructura;

namespace Services
{
    public class ServiceBase //: IDisposable
    {
        readonly IUnitOfWork _unitOfWork;
        public ServiceBase()
        {

        }
    }
}
