using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public sealed class BoloChocolate : Bolo
{
    public BoloChocolate() : base("Bolo de chocolate", TipoMassa.Bolo)
    {
        Ingredientes.Add("Com cobertura de chocolate nestlé");
    }
}