namespace DesignPatterns.Criacionais.SimpleFactory;

public class Pizzaria
{
    public static void SolicitarPizza()
    {
        Console.WriteLine("=================Pizzaria==============");
        Console.WriteLine("Informe a Pizza (C)Calabreza ou (M)Mussarela\n");
        
        var tipo = Console.ReadLine().ToUpper();

        try
        {
            var pizza = PizzaSimpleFactory.CriarPizza(tipo);
            pizza.Preparar();
            Thread.Sleep(9000);
            pizza.Assar(10);
            Thread.Sleep(9000);
            pizza.Embalar();
            Thread.Sleep(9000);
            Console.WriteLine("Pizza concluída");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }
    }
}