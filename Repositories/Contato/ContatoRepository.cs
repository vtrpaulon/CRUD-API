using CRUD_API.Context;
using CRUD_API.Model;

namespace CRUD_API.Repositories
{
    public class ContatoRepository(AgendaContext context) : IContatoRepository
    {
        public async Task CreateContato(Contato contato)
        {
            await context.AddAsync(contato);
            await context.SaveChangesAsync();
        }
    }
}