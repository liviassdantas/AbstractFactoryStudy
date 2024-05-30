using AbstractFactoryStudy.Application.ValueObjects;

namespace AbstractFactoryStudy.Application.Business
{
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa) { }
    }
}
