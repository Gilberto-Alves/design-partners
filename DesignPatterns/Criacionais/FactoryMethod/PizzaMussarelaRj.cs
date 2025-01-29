namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaMussarelaRj : Pizza
{
    public PizzaMussarelaRj()
    {
        Nome = "Pizza de mussarela Carioca";
        massa = "Massa tradicional carioca";
        molho = "Molho de tomate italiano carioca";
        ingrientes.Add("Queijo parmesão ralado");
        ingrientes.Add("Azeitonas pretas");
    }
}