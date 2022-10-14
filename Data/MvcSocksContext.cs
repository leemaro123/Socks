using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcSocks.Models;

namespace MvcSocks.Data
{
    public class MvcSocksContext : DbContext
    {
        public MvcSocksContext(DbContextOptions<MvcSocksContext> options)
            : base(options)
        {
        }

        public DbSet<socks> Socks { get; set; }
    }
}
