using System;

namespace consoleapp001
{
    public class Carro : Veiculo
    {
        public Carro() : base()
        { }

        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }

        public override void Imprimir()        
        {
            base.Imprimir(); 
        }
    }
}