using CRUD_API.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Context
{
    public class AgendaContext : DbContext

    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
    }
}
