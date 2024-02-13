using SmartBackend.CORE.Interfaces;
using SmartBackend.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBackend.EF.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Cliente> SpecialMethod()
        {
            throw new NotImplementedException();
        }
    }
}
