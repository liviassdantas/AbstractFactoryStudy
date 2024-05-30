using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.FactoryMethod;
using AbstractFactoryStudy.Application.Sealed;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.FactoryClass
{
    public sealed class PizzaFactory : IMassaFactoryMethod
    {
        public MassaBase CriarMassa(Enum massaFactoryType)
        {
            var tipoPizza = (TipoPizza)massaFactoryType;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    {
                        return new PizzaMussarela();
                    }
                case TipoPizza.Calabresa:
                    {
                        return new PizzaCalabresa();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
