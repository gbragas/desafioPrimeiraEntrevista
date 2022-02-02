using locadora_braga.Models;
using locadora_braga.Dao;

namespace locadora_braga.Services
{
    public class FilmeServices : ServiceBase<Filme>
    {
        private readonly FilmeDao dao = new();

        public List<Filme> listarTodos()
        {
            return dao.buscarTodos();
        }
        public void salvar(Filme entidade)
        {
            dao.salvar(entidade);
        }
        public void deletar(string id)
        {
            dao.deletar(id);
        }

    }
}
