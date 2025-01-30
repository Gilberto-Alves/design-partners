using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public sealed class BoloLaranja : Bolo
{
    public BoloLaranja() : base("Bolo de laranja", TipoMassa.Bolo)
    {
        Ingredientes.Add("Com cobertura de calda de laranja");
    }
}