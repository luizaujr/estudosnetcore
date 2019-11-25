using System;

namespace consoleapp001
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro teste = new Carro()
            {
                ID = 1,
                Fabricante = "Fiat",
                Marca = "Toro",
                DataDeFabricacao = new DateTime(1998, 12, 15)
            };

            Console.WriteLine("ID - {0}", teste.ID);
            Console.WriteLine("Fabricante - {0}", teste.Fabricante);
            Console.WriteLine("Marca - {0}", teste.Marca);
            Console.WriteLine("Data de Fabricação - {0}", teste.DataDeFabricacao);

            Console.ReadLine();
        }
    }
}
