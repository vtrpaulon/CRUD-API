using CRUD_API.Model;
using CRUD_API.Services.Contato;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API.Controllers_API.Controllers
{
    //api/contato
    [Route("[controller]")]
    public class ContatoController(IContatoService contatoService) : ControllerBase
    {

        [HttpPost("create")]
        public async Task<IActionResult> Criar(Contato contato)
        {
            await contatoService.CriarAsync(contato);
            return Created("", contato);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var contato = await contatoService.ObterPorId(id);
            return Ok(contato);
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var lista = await contatoService.ListarAsync();
            return Ok(lista);
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] Contato contato)
        {
            await contatoService.AtualizarAsync(contato);

            return Ok();
        }


        /*[HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var contatoDoBanco = await contatoRepository.GetByIdAsync(id);

            if (contatoDoBanco == null)
            {
                return NotFound();
            }
            await contatoRepository.DeletarAsync(contatoDoBanco);

            return Ok();
        } */
    }
}