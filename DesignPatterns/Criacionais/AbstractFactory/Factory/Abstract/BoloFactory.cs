using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;
using DesignPatterns.Criacionais.AbstractFactory.Products;

namespace DesignPatterns.Criacionais.AbstractFactory.Factory.Abstract;

public sealed class BoloFactory : MassaFactory
{
    public override MassaBase CriaMassa(TipoMassa tipoMassa)
    {
        var tipoBolo = (TipoBolo)tipoMassa;

        return tipoBolo switch
        {
            TipoBolo.Chocolate => new BoloChocolate(),
            TipoBolo.Laranja => new BoloLaranja(),
            _ => throw new ArgumentOutOfRangeException("Tipo não implementado")
        };
    }
}