namespace PizzaShop.PizzaFramework
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizzaBase = CreatePizza(type);

            pizzaBase.Prepare();
            pizzaBase.Bake();
            pizzaBase.Cut();
            pizzaBase.Box();

            return pizzaBase;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
