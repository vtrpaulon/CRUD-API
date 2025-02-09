using CRUD_API.Model;
using CRUD_API.Repositories;
using Microsoft.AspNetCore.Mvc;

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

        /* [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var contatos = _context.Contatos;
            return Ok(contatos);
        }

        [HttpGet("listar-por-nome")]
        public IActionResult ListarPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null)
            {
                return NotFound();
            }
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Email = contato.Email;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
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