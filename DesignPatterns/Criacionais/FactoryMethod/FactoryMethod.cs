namespace DesignPatterns.Criacionais.FactoryMethod;

public static class FactoryMethod
{
    public static void Factory()
    {
        Console.WriteLine("============ Pizzaria ============\n");
        Console.WriteLine("Informe o local (S)São Paulo (R)Rio de Janeiro");
        var local = Console.ReadLine()!.ToUpper();
        
        Console.WriteLine("EScolha a pizza (M)Mussarela (C)Calabreza");
        var pizzaEcolhida = Console.ReadLine()!.ToUpper();

        try
        {
            PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(local);

            var pizza = pizzaria.MontaPizza(pizzaEcolhida);

            Console.WriteLine(pizza.Preparar());
            Console.WriteLine("\nPizza concluida com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        Console.ReadLine();
    }
}