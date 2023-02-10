using api_banco_virtual.Models;
using Microsoft.EntityFrameworkCore;

namespace api_banco_virtual.Context
{
    public class BancoVirtualContext : DbContext
    {
        public BancoVirtualContext(DbContextOptions<BancoVirtualContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
    }
}