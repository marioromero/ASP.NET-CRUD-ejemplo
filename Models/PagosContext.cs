using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudASPEjemplo.Models
{
    public class PagosContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-V72PCSQ;Initial Catalog=pagos_crud;Integrated Security=True");
        }

        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}