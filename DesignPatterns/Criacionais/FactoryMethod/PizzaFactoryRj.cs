namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaFactoryRj : PizzaFactoryMethod
{
    protected override Pizza CriarPizza(string tipo)
    {
        return tipo switch
        {
            "M" => new PizzaMussarelaRj(),
            "C" => new PizzaCalabrezaRj(),
            _ => null
        };
    }
}