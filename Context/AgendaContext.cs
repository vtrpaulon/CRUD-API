using CRUD_API.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        public DbSet<Contato> Contatos { get; set; }
    }
}
