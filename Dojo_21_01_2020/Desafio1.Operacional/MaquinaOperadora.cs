using System.Collections.Generic;

namespace Desafio1.Operacional
{
    public class MaquinaOperadora
    {
        public List<Acionador> acionadores { get; } = new List<Acionador>();
        
        public void Conectar(Acionador acionador)
        {
            acionadores.Add(acionador);
        }
    }
}
