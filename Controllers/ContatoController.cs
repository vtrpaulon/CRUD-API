using CRUD_API.Model;
using CRUD_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Controllers_API.Controllers
{
    //api/contato
    [Route("[controller]")]
    public class ContatoController(IContatoRepository contatoRepository) : ControllerBase
    {

        [HttpPost("create")]
        public async Task<IActionResult> Create(Contato contato)
        {
            await contatoRepository.CreateContatoAsync(contato);
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var contato = await contatoRepository.GetByIdAsync(id);
            return Ok(contato);
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var lista = await contatoRepository.GetAllAsync();
            return Ok(lista);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] Contato contato)
        {
            var contatoDoBanco = await contatoRepository.GetByIdAsync(contato.Id); // Busca o contato no banco

            if (contatoDoBanco == null)
            {
                return NotFound();
            }

            contatoDoBanco.Update(contato.Nome, contato.Email, contato.Telefone, contato.Ativo);

            await contatoRepository.UpdateAsync(contatoDoBanco);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var contatoDoBanco = await contatoRepository.GetByIdAsync(id);

            if (contatoDoBanco == null)
            {
                return NotFound();
            }
            await contatoRepository.DeletarAsync(contatoDoBanco);

            return Ok();
        }
    }
}