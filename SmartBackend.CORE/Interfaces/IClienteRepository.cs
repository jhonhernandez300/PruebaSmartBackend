﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBackend.CORE.Models;

namespace SmartBackend.CORE.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        IEnumerable<Cliente> SpecialMethod();
    }
}
