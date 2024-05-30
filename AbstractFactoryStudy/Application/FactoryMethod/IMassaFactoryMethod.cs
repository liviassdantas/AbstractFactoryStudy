using AbstractFactoryStudy.Application.Business;

namespace AbstractFactoryStudy.Application.FactoryMethod
{
    public interface IMassaFactoryMethod
    {
        MassaBase CriarMassa(Enum massaFactoryType);
    }
}
