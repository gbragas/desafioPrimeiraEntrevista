using locadora_braga.Models;

namespace locadora_braga.Dao
{
    public interface DaoBase<E, ID>
    {
        void salvar(E entidade);

        E? buscarPorId(ID id);

        List<E> buscarTodos();

        int? deletar(ID id);

    }
}
