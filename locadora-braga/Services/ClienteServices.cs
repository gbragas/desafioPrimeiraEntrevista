using locadora_braga.Models;
using locadora_braga.Dao;

namespace locadora_braga.Services
{
    public class ClienteServices : ServiceBase<Cliente>
    {
        private readonly ClienteDao dao = new();

        public List<Cliente> listarTodos()
        {
            return dao.buscarTodos();
        }

        public void salvar(Cliente entidade)
        {
            dao.salvar(entidade);
        }

        public Cliente? buscarPorId(string cpf)
        {
            return dao.buscarPorId(cpf);
        }

        public void deletar(string cpf)
        {
            dao.deletar(cpf);
        }
    }
}
