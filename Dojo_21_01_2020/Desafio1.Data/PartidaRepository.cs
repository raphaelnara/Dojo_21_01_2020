using System;
using Desafio1.Model;

namespace Desafio1.Data
{
    public class PartidaRepository : IRepository<Partida>
    {
        public void Salvar(Partida registro)
        {
            Console.Write("Partida salva no banco!");
        }
    }
}
