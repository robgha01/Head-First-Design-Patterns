using System;
using MiniDuckSimulator.DuckSim.Interfaces.Behaviors;

namespace MiniDuckSimulator.DuckSim.Behaviors.Fly
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
