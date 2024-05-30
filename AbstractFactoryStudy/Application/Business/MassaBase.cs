using AbstractFactoryStudy.Application.ValueObjects;
using AbstractFactoryStudy.Domain;
using System.Collections;

namespace AbstractFactoryStudy.Application.Business
{
    public abstract class MassaBase
    {
        public ArrayList Ingredientes = new ArrayList();
        private readonly MassaBaseModel massaBaseModel = new MassaBaseModel();

        public MassaBase(string nome, TipoMassa tipoMassa)
        {
            massaBaseModel.Nome = nome; 
            massaBaseModel.TipoMassa = tipoMassa;
        }
    }
}
