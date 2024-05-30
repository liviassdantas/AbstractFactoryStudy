using AbstractFactoryStudy.Application.Business;
using AbstractFactoryStudy.Application.FactoryClass;
using AbstractFactoryStudy.Application.ValueObjects;

public class Program
{
    private static void Main(string[] args)
    {
        var boloFactory = MassasAbstractFactory.CriaMassa(TipoMassa.Bolo);
        var pizzaFactory = MassasAbstractFactory.CriaMassa(TipoMassa.Pizza);

        var boloChocolate = boloFactory.CriarMassa(TipoBolo.Chocolate);
        var boloLaranja = boloFactory.CriarMassa(TipoBolo.Laranja);

        var pizzaCalabresa = pizzaFactory.CriarMassa(TipoPizza.Calabresa);
        var pizzaMussarela = pizzaFactory.CriarMassa(TipoPizza.Mussarela);

        ExibeDetalhes(boloLaranja);
        ExibeDetalhes(boloChocolate);
        ExibeDetalhes(pizzaMussarela);
        ExibeDetalhes(pizzaCalabresa);

        Console.ReadLine();
    }
    private static void ExibeDetalhes(MassaBase massaBase)
    {
        Console.WriteLine($"Tipo : {massaBase.massaBaseModel.TipoMassa}");
        Console.WriteLine(massaBase.massaBaseModel.Nome);
        Console.WriteLine(massaBase.Ingredientes[0].ToString());
        Console.WriteLine("\n");
    }
}
