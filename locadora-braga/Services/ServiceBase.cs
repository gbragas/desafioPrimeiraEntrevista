namespace locadora_braga.Services
{
    public interface ServiceBase<E>
    {
        void salvar(E entidade);

        List<E> listarTodos();
    }
}
