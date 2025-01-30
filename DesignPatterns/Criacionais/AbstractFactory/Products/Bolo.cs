using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public abstract class Bolo : MassaBase
{
    protected Bolo(string nome, TipoMassa tipo) : base(nome, tipo)
    {
    }
}