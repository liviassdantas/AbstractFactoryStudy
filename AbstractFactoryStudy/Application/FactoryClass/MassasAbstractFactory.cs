using AbstractFactoryStudy.Application.FactoryMethod;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.FactoryClass
{
    public abstract class MassasAbstractFactory
    {
        public static IMassaFactoryMethod CriaMassa (TipoMassa tipoMassa) 
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                    {
                        return new PizzaFactory();
                    }
                case TipoMassa.Bolo:
                    {
                        return new BoloFactory();
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa),
                      tipoMassa, null);
            }

        }
            
    }
}
