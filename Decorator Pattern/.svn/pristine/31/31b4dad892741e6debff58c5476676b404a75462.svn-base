namespace StarbuzzCoffee.Shop.Condiments
{
    public class Whip : CondimentDecorator
    {
        readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
