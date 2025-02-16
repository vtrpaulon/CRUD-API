using CRUD_API.Context;
using CRUD_API.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Repositories
{
    public class ContatoRepository(AgendaContext context) : IContatoRepository
    {
        public async Task CreateContatoAsync(Contato contato)
        {
            await context.AddAsync(contato);
            await context.SaveChangesAsync();
        }

        public async Task DeletarAsync(Contato contato)
        {
            context.Contatos.Remove(contato);
            await context.SaveChangesAsync();
        }

        public async Task<List<Contato>> GetAllAsync()
        {
            return await context.Contatos.AsNoTracking().ToListAsync();
        }

        public async Task<Contato?> GetByIdAsync(int id)
        {
            return await context.Contatos.AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(Contato contato)
        {
            context.Contatos.Update(contato);
            await context.SaveChangesAsync();
        }

    }
}