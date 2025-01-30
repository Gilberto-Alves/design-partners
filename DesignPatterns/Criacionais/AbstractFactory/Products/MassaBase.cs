using System.Collections;
using DesignPatterns.Criacionais.AbstractFactory.Domain.Enums;

namespace DesignPatterns.Criacionais.AbstractFactory.Products;

public abstract class MassaBase
{
   public TipoMassa TipoMassa { get; set; }
   public string Nome { get; set; }
   public ArrayList Ingredientes =  new ArrayList();

   public MassaBase(string nome, TipoMassa tipo)
   {
      Nome = nome;
      TipoMassa = tipo;
   }
}