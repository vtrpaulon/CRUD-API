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
            await contatoRepository.CreateContato(contato);
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            await contatoRepository.GetByID(id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            await contatoRepository.GetAll();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, Contato contato)
        {
            await contatoRepository.FindAsync(id); // Busca o contato no banco

            if (contato == null)
            {
                return NotFound();
            }

            // Atualiza os dados do contato
            contato.Nome = contato.Nome;
            contato.Email = contato.Email;
            contato.Telefone = contato.Telefone;
            contato.Ativo = contato.Ativo;

            contato.Update(contato);
            await contato.SaveChangesAsync(); // Adiciona await para operação assíncrona

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return Ok();
        } */
    }
}