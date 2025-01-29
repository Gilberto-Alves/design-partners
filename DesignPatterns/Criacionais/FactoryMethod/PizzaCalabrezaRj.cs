namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaCalabrezaRj : Pizza
{
    public PizzaCalabrezaRj()
    {
        Nome = "Pizza de calabreza Carioca com cebola";
        massa = "Massa tradicional carioca";
        molho = "Molho de tomate italiano carioca";
        ingrientes.Add("Fatias de calabreza especial");
        ingrientes.Add("Queijo parmesão italiano tradicional");
    }
}