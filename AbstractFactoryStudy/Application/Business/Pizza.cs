using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.Business
{
    public abstract class Pizza : MassaBase
    {
        protected Pizza(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
        {
        }
    }
}
