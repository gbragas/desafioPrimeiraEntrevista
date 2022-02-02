using Microsoft.AspNetCore.Mvc;
using locadora_braga.Models;
using locadora_braga.Services;

namespace locadora_braga.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocacaoController : ControllerBase
    {
        private readonly LocacaoServices service = new();

        [HttpDelete()]
        public string Delete(string id)
        {
            return service.deletar(id);
        }

        [HttpGet()]
        public List<Locacao> GetAll()
        {
            return service.listarTodos();
        }

        [HttpPost()]
        public void Post(Locacao locacao)
        {
            service.salvar(locacao);
        }
    }
}
