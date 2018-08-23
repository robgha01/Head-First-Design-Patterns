using PizzaShop.PizzaFramework.Pizzas.NyStyle;

namespace PizzaShop.PizzaFramework.Stores
{
    public class NyStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NyStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NyStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NyStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NyStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
