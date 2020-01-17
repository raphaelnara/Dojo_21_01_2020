namespace Desafio1.Data
{
    public interface IRepository<T>
    {
        void Salvar(T registro);
    }
}
