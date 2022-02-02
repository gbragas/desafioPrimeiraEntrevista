using locadora_braga.Models;

namespace locadora_braga.Dao
{
    public class FilmeDao : DaoBase<Filme, string>
    {
        public Filme? buscarPorId (string id)
        {
            return DbLocadora.filmes.Find(filme => filme.id.Equals(id));
        }

        public List<Filme> buscarTodos()
        {
            return DbLocadora.filmes.FindAll(filme => !filme.excluido);
        }

        public int? deletar(string id)
        {
            Filme? c = buscarPorId(id);
            if (c != null)
            {
                c.excluido = true;
                salvar(c);
            }
            return null;
        }

        public void salvar(Filme entidade)
        {
            if (buscarPorId(entidade.id) == null)
            {
                DbLocadora.filmes.Add(entidade);
            }
        }


    }
}
