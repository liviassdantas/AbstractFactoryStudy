using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.Sealed
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Bolo sabor laranja com cobertura de laranja");
        }
    }
}
