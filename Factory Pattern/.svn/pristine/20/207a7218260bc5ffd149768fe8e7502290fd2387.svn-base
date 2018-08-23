using PizzaShop.PizzaFramework.Factory;

namespace PizzaShop.PizzaFramework
{
    public class PizzaStoreV1
    {
        protected SimplePizzaFactory Factory;

        public PizzaStoreV1(SimplePizzaFactory factory)
        {
            Factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizzaBase = Factory.CreatePizza(type);

            pizzaBase.Prepare();
            pizzaBase.Bake();
            pizzaBase.Cut();
            pizzaBase.Box();

            return pizzaBase;
        }
    }
}
