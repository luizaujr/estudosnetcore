using System;

namespace consoleapp001
{
    public abstract class Veiculo
    {
        public Veiculo()
        { }

        public int ID { get; set; }

        public string Fabricante { get; set; }

        public string Marca { get; set; }

        public DateTime DataDeFabricacao { get; set; }

        public abstract void Ligar();

        public abstract void Desligar();

        public virtual void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}