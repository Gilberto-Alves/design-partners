using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;
using DesignPatterns.Criacionais.AbstractFactory.Products;

namespace DesignPatterns.Criacionais.AbstractFactory.Factory.Abstract;

public sealed class PizzaFactory : MassaFactory
{
    public override MassaBase CriaMassa(TipoMassa tipoMassa)
    {
        var tipoPizza = (TipoPizza)tipoMassa;

        return tipoPizza switch
        {
            TipoPizza.Calabreza => new PizzaCalabreza(),
            TipoPizza.Mussarela => new PizzaMussarela(),
            _ => throw new ArgumentOutOfRangeException("Tipo não implementado")
        };
    }
}