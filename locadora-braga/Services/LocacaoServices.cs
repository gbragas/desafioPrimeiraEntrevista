using locadora_braga.Models;
using locadora_braga.Dao;

namespace locadora_braga.Services
{
    public class LocacaoServices
    {
        private readonly LocacaoDao dao = new();

        public string deletar(string id)
        {
            int? atrasado = dao.deletar(id);
            Console.WriteLine(atrasado);
            switch (atrasado)
            {
                case > 0:
                    return "Estava atrasado"; 
                case <= 0:
                    return "Entregou dentro do prazo";   
                default:
                    return "Nao tinha locacao";
            }
        }
        public List<Locacao> listarTodos()
        {
            return dao.buscarTodos();
        }
        public void salvar(Locacao entidade)
        {
            dao.salvar(entidade);
        }
    }
}
