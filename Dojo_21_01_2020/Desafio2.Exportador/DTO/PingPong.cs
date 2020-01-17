using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Exportador.DTO
{
    public class PingPong
    {
        public DateTime Data { get; set; }

        public string Jogador1Equipe1 { get; set; }
        public string Jogador2Equipe1 { get; set; }
        public string Jogador1Equipe2 { get; set; }
        public string Jogador2Equipe2 { get; set; }

        public PingPong(DateTime data, string jogador1Equipe1, string jogador2Equipe1, string jogador1Equipe2, string jogador2Equipe2)
        {
            Data = data;
            Jogador1Equipe1 = jogador1Equipe1;
            Jogador2Equipe1 = jogador2Equipe1;
            Jogador1Equipe2 = jogador1Equipe2;
            Jogador2Equipe2 = jogador2Equipe2;
        }

        public string Jogar()
        {
            var random = new Random();
            var value = random.Next();
            return value % 2 == 0 ? $"{Jogador1Equipe1} / {Jogador2Equipe1}" : $"{Jogador1Equipe2} / {Jogador1Equipe2}";
        }
    }
}
