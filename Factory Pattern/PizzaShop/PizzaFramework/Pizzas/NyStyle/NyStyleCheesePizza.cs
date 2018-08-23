namespace PizzaShop.PizzaFramework.Pizzas.NyStyle
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "Ny Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
