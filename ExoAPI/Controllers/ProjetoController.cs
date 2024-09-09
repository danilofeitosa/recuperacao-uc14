using ExoAPI.Domains;
using ExoAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_projetoRepository.Listar());
        }
        [HttpPost]
        public IActionResult Post(Projeto projeto)
        {
            _projetoRepository.Criar(projeto);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Put(int id, Projeto projeto)
        {
            _projetoRepository.Atualizar(id, projeto);
            return NoContent();
        }
        [HttpDelete]
        public  IActionResult Delete(int id)
        {
            _projetoRepository.Deletar(id);
            return NoContent();
        }
    }
}
