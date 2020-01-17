namespace Desafio1.Operacional
{
    public class Acionador
    {
        Lampada _lampada = new Lampada();
        
        public void On()
        {
            _lampada.Ligar();
        }

        public void Off()
        {
            _lampada.Desligar();
        }
    }
}
