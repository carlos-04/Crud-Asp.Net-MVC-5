using MvcPatronRepo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace MvcPatronRepo.Persisten
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext() : 
        base("DbClientesRepo")
        {
                
        }

        public DbSet<Clientes> cliente { get; set; } 
    }
}