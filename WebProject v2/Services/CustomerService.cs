using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructura;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        readonly AppContext _dbContext;
        public CustomerService(AppContext dbContext)
        {
            if (null == dbContext)
            {
                throw new ArgumentNullException("repository");
            }
            _dbContext = dbContext;
        }

        public Customer Add()
        {
            _dbContext.Add();
        }

        public Customer Get()
        {
            _dbContext.Get();
        }

        public void Update()
        {
            _dbContext.Update();
        }

        public void Delete()
        {
            _dbContext.Delete();
        }
    }
}
