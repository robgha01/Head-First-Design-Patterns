namespace StarbuzzCoffee.Shop.Condiments
{
    public class Mocha : CondimentDecorator
    {
        readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}
