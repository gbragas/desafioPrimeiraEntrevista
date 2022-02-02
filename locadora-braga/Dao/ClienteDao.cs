using locadora_braga.Models;

namespace locadora_braga.Dao
{
    public class ClienteDao : DaoBase<Cliente, string>
    {
        public Cliente? buscarPorId(string id)
        {
            return DbLocadora.clientes.Find(cliente => cliente.cpf.Equals(id));
        }

        public List<Cliente> buscarTodos()
        {
            return DbLocadora.clientes.FindAll(cliente => !cliente.excluido);
        }

        public int? deletar(string id)
        {
            Cliente? c = buscarPorId(id);
            if (c != null) 
            {
                c.excluido = true;
                salvar(c);
            }
            return null;
        }

        public void salvar(Cliente entidade)
        {
            if(buscarPorId(entidade.cpf) == null)
            {
                DbLocadora.clientes.Add(entidade);
            }

        }
    }
}
