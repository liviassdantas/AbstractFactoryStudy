using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.Sealed
{
    public class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", TipoMassa.Bolo)
        {
            Ingredientes.Add("Bolo sabor chocolate com cobertura de ganache");
        }
    }
}
