using Microsoft.AspNetCore.Mvc;
using locadora_braga.Models;
using locadora_braga.Services;

namespace locadora_braga.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly FilmeServices service = new();

        [HttpGet()]
        public List<Filme> GetAll()
        {
            return service.listarTodos();
        }

        [HttpPost()]
        public void Post(Filme filme)
        {
            service.salvar(filme);
        }

        [HttpPut()]
        public void Put(Filme filme, string id)
        {

        }

        [HttpDelete()]
        public void Delete(string id)
        {
            service.deletar(id);
        }
    }
}
