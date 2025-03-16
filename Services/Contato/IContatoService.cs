namespace CRUD_API.Services.Contato
{
    public interface IContatoService
    {
        Task CriarAsync(Model.Contato contato);
        Task<Model.Contato?> ObterPorId(int id);
        Task<List<Model.Contato>> ListarAsync();
        Task AtualizarAsync(Model.Contato contato);
        Task DeletarAsync(Model.Contato contato);
    }
}