﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infraestructura
{
    public interface IUnitOfWork:IDisposable
    {
        public int SaveChanges { get; set; }
    }
}
