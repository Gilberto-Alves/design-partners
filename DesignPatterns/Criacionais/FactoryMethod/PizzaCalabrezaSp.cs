namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaCalabrezaSp : Pizza
{
    public PizzaCalabrezaSp()
    {
        Nome = "Pizza de calabreza Paulista com muita calabreza";
        massa = "Massa fina crocante";
        molho = "Molho de tomate italiano";
        ingrientes.Add("Fatias de calabreza defumada especial");
        ingrientes.Add("Queijo parmesão italiano tradicional");
    }
}