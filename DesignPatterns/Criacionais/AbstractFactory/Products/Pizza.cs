using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public abstract class Pizza : MassaBase
{
    public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
    {
    }
}