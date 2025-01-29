namespace DesignPatterns.Criacionais.FactoryMethod;

public class PizzaMussarelaSp : Pizza
{
    public PizzaMussarelaSp()
    {
        Nome = "Pizza Mussarela Paulista";
        massa = "Massa fina crocante paulista";
        molho = "Molho de tomate italiano paulista";
        ingrientes.Add("Queijo parmesão");
        ingrientes.Add("Azeitonas verdes");
    }
}