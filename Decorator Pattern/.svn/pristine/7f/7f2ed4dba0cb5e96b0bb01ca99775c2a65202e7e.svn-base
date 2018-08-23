namespace StarbuzzCoffee.Shop.Condiments
{
    public class Soy : CondimentDecorator
    {
        readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return .15 + _beverage.Cost();
        }
    }
}
