using locadora_braga.Models;
using System;

namespace locadora_braga.Dao
{
    public class LocacaoDao
    {   
        public ClienteDao clienteDao { get; set; }

        public FilmeDao filmeDao { get; set; }

        public LocacaoDao()
        {
            clienteDao = new ClienteDao();
            filmeDao = new FilmeDao();
        }
        public Locacao? buscarPorId(string id)
        {
            return DbLocadora.locacoes.Find(locacao => locacao.id.Equals(id));
        }

        private Locacao? buscarPorFilme(string id)
        {
            return DbLocadora.locacoes.Find(locacao => locacao.idFilme.Equals(id) && !locacao.excluido);
        }

        public List<Locacao> buscarTodos()
        {
            return DbLocadora.locacoes.FindAll(locacao => !locacao.excluido);
        }

        public int? deletar(string id)
        {
            Locacao? c = buscarPorId(id);
            if (c != null)
            {
                c.excluido = true;
                salvar(c);
                return DateTime.Compare(DateTime.Now, c.dataPrazo);
            }
            return null;
        }

        public void salvar(Locacao entidade)
        {
            if (buscarPorId(entidade.id) == null && clienteDao.buscarPorId(entidade.cpfCliente) != null && filmeDao.buscarPorId(entidade.idFilme) != null && buscarPorFilme(entidade.idFilme) == null)
            {
                DbLocadora.locacoes.Add(entidade);
            }
        }
    }
}
