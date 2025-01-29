namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaSimpleFactory
{
    public static PizzaFactoryMethod CriarPizzaria(string local)
    {
        PizzaFactoryMethod pizzaria = local switch
        {
            "S" => new PizzaFactorySp(),
            "R" => new PizzaFactoryRj(),
            _ => throw new ApplicationException($"A pizzaria {local} não foi encontrada")
        };

        return pizzaria;
    }
}