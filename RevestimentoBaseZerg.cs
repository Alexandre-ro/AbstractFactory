using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    internal class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha.");
        }
    }
}
