using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;
using DesignPatterns.Criacionais.AbstractFactory.Factory.Abstract;
using DesignPatterns.Criacionais.AbstractFactory.Products;

namespace DesignPatterns.Criacionais.AbstractFactory;

public static class AbstractFactory
{
    public static void Factory()
    {
        //Obtém as fábricas
        var boloFactory = MassaFactory.CriaFabricaMassas(TipoMassa.Bolo);
        var pizzaFactory = MassaFactory.CriaFabricaMassas(TipoMassa.Pizza);
        
        //cria os objetos com base no tipo : bolo
        var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
        var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);
        
        //cria os objetos com base no tipo : pizza
        var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
        var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabreza);

        ExibeDetalhes(bolo1);
        ExibeDetalhes(bolo2);
        ExibeDetalhes(pizza1);
        ExibeDetalhes(pizza2);
        
        Console.ReadLine();
    }
    
    private static void ExibeDetalhes(MassaBase massaBase)
    {
        Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
        Console.WriteLine(massaBase.Nome);
        Console.WriteLine(massaBase.Ingredientes[0]!.ToString());
        Console.WriteLine("\n");
    }
}