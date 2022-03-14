using AbstractFactory.Interface;

namespace AbstractFactory
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            System.Console.WriteLine("Base revestida pela cor verde.");
        }
    }
}
