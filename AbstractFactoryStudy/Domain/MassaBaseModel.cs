using AbstractFactoryStudy.Application.ValueObjects;
using System.Collections;

namespace AbstractFactoryStudy.Domain
{
    public class MassaBaseModel
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }
    }
}
