using CRUD_API.Model;

namespace CRUD_API.Repositories;

public interface IContatoRepository
{
    Task CreateContato(Contato contato);
}