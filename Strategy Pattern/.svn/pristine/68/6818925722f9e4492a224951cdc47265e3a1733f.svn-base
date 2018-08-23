using MiniDuckSimulator.DuckSim;
using MiniDuckSimulator.DuckSim.Behaviors.Fly;
using MiniDuckSimulator.DuckSim.Ducks;

namespace MiniDuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new ModelDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            mallard.SetFlyBehavior(new FlyRocketPowered());
            mallard.PerformFly();
        }
    }
}
