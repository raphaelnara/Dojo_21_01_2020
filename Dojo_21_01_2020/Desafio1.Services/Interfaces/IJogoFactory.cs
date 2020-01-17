namespace Desafio1.Services.Interfaces
{
    public interface IJogoFactory
    {
        IJogoService CriarJogo(string id);
    }
}
