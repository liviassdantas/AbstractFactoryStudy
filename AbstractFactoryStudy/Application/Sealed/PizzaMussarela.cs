using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.Sealed
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza de Mussarela", TipoMassa.Pizza)
        {
            Ingredientes.Add("Mussarela com orégano");
        }
    }
}
