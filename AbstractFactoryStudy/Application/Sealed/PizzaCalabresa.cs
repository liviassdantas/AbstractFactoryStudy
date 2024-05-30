using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.Sealed
{
    public sealed class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base("Pizza de Calabresa", TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabresa em cubos, tomates em cubos");
        }
    }
}
