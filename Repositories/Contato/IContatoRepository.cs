using CRUD_API.Model;

namespace CRUD_API.Repositories;

public interface IContatoRepository
{
    Task CreateContatoAsync(Contato contato);
    Task<List<Contato>> GetAllAsync();
    Task<Contato?> GetByIdAsync(int id);
    Task UpdateAsync(Contato contato);

    Task DeletarAsync(Contato contato);
}