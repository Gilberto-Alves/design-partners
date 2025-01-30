using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public sealed class PizzaMussarela : Pizza
{
    public PizzaMussarela() : base("Pizza Mussarela", TipoMassa.Pizza)
    {
        Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
    }
}