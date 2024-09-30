using Microsoft.EntityFrameworkCore;
using trabalhoClientes.Models;

namespace trabalhoClientes.Context
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont>options) : base (options)
        {

        }

        public DbSet<CadCliente> Clientes { get; set; }
    }
}
