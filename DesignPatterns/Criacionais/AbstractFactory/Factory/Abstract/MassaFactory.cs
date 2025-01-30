using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;
using DesignPatterns.Criacionais.AbstractFactory.Products;

namespace DesignPatterns.Criacionais.AbstractFactory.Factory.Abstract;

public abstract class MassaFactory
{
    public abstract MassaBase CriaMassa(TipoMassa tipoMassa);

    public static MassaFactory CriaFabricaMassas(TipoMassa tipoMassa)
    {
        return tipoMassa switch
        {
            TipoMassa.Pizza => new PizzaFactory(),
            TipoMassa.Bolo => new BoloFactory(),
            _ => throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null)
        };
    }
}