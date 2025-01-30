using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public sealed class PizzaCalabreza : Pizza
{
    public PizzaCalabreza() : base("Pizza Calabreza", TipoMassa.Pizza)
    {
        Ingredientes.Add("Calabreza em cubos e tomates em cubos");
    }
}