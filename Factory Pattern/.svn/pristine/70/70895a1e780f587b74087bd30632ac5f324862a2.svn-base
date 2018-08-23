using System;
using PizzaShop.PizzaFramework;
using PizzaShop.PizzaFramework.Stores;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NyStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");
        }
    }
}
