using Microsoft.AspNetCore.Mvc;
using locadora_braga.Models;
using locadora_braga.Services;

namespace locadora_braga.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteServices service = new();

        
        [Route("/{cpf}")]
        [HttpGet()]
        public Cliente? GetById(string cpf)
        {
            return service.buscarPorId(cpf);
        }

        [HttpGet()]
        public List<Cliente> GetAll()
        {
            return service.listarTodos();
        }

        [HttpPost()]
        public void Post(Cliente cliente)
        {
            service.salvar(cliente);
        }

        [HttpPut()]
        public void Put(Cliente cliente, string cpf)
        {
            
        }

        [HttpDelete()]
        public void Delete(string cpf)
        {
            service.deletar(cpf);
        }
    }
}
