using PizzaShop.PizzaFramework.Pizzas.ChicagoStyle;

namespace PizzaShop.PizzaFramework.Stores
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
