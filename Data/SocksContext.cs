using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcSocks.Models;

namespace Socks.Data
{
    public class SocksContext : DbContext
    {
        public SocksContext (DbContextOptions<SocksContext> options)
            : base(options)
        {
        }

        public DbSet<MvcSocks.Models.socks> socks { get; set; }
    }
}
