using System;
using Desafio1.Model;

namespace Desafio1.Data
{
    public class PlacarRepository : IRepository<Placar>
    {
        public void Salvar(Placar registro)
        {
            Console.WriteLine("Placar da partida salva no banco de dados!");
        }
    }
}
