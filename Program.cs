using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Abstract Factory --------");

            IFabricaBase fabrica;

            Console.WriteLine("Escolha um Personagem: 1 - Protons| 2 - Zergs | 3 - Terranos");

            switch (Console.ReadLine())
            {
                case "1":
                    fabrica = new FabricaBaseProtoss();
                    break;
                case "2":
                    fabrica = new FabricaBaseZerg();
                    break;
                case "3":
                    fabrica = new FabricaBaseTerran();
                    break;
            }

            Console.ReadLine();
        }
    }
}
