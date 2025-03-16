
using CRUD_API.Repositories;

namespace CRUD_API.Services.Contato
{
    public class ContatoService(IContatoRepository contatoRepository) : IContatoService
    {
        public async Task CriarAsync(Model.Contato contato)
        {
            //exemplo de regra de negócio
            //email sempre com letras minúsculas
            contato.Update(contato.Nome, contato.Email.ToLower(), contato.Telefone, contato.Ativo);
            await contatoRepository.CreateContatoAsync(contato);
        }

        public async Task<Model.Contato?> ObterPorId(int id)
        {
            return await contatoRepository.GetByIdAsync(id);
        }

        public async Task<List<Model.Contato>> ListarAsync()
        {
            return await contatoRepository.GetAllAsync();
        }

        public async Task AtualizarAsync(Model.Contato contato)
        {
            await contatoRepository.UpdateAsync(contato);
        }
        public async Task DeletarAsync(Model.Contato contato)
        {
            await contatoRepository.DeletarAsync(contato);
        }
    }
}