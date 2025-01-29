namespace DesignPatterns.Criacionais.SimpleFactory;

public sealed class PizzaSimpleFactory
{
    public static Pizza CriarPizza(string tipo)
    {
        Pizza pizza = tipo switch
        {
            "C" => new PizzaCalabreza(),
            "M" => new PizzaMussarela(),
            _ => throw new ApplicationException($"A pizza de {tipo} não foi criada")
        };

        return pizza;
    }
}