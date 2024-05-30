using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.FactoryMethod;
using AbstractFactoryStudy.Application.Sealed;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.FactoryClass
{
    public sealed class BoloFactory : IMassaFactoryMethod
    {
        public MassaBase CriarMassa(Enum massaFactoryType)
        {
            var tipoBolo = (TipoBolo)massaFactoryType;

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    {
                        return new BoloChocolate();
                    }
                case TipoBolo.Laranja:
                    {
                        return new BoloLaranja();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }

    }
}
