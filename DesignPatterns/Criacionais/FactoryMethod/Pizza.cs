using System.Collections;
using System.Text;

namespace DesignPatterns.Criacionais.FactoryMethod;

public abstract class Pizza
{
    protected string Nome { get; set; }
    protected string massa;
    protected string molho;
    protected ArrayList ingrientes = new ArrayList();

    public string Preparar()
    {
        var sb = new StringBuilder();
        
        sb.Append("Preparando " + Nome + "\n");
        sb.Append(massa + "\n");
        sb.Append(molho + "\n");
        sb.Append("Igredientes :" + "\n");
        foreach (string ingrediente in ingrientes)
        {
            sb.Append("\t" + ingrediente + "\n");
        }
        sb.Append(Cozinhar());
        sb.Append(Fatiar());
        sb.Append(Embalar());
        return sb.ToString();
    }

    public virtual string Cozinhar()
    {
        return "Cozinhar por 25 minutos a 350 graus \n";
    }
    public virtual string Fatiar()
    {
        return "Fatiar a pizza em 8 pedaços \n";
    }
    public virtual string Embalar()
    {
        return "Embalar a pizza com embalagem oficial \n";
    }
}