namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaFactorySp : PizzaFactoryMethod
{
    protected override Pizza CriarPizza(string tipo)
    {
        return tipo switch
        {
            "M" => new PizzaMussarelaSp(),
            "C" => new PizzaCalabrezaSp(),
            _ => null
        };
    }
}