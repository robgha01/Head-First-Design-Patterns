using System;
using MiniDuckSimulator.DuckSim.Interfaces.Behaviors;

namespace MiniDuckSimulator.DuckSim.Behaviors.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            // implaments duck flying
            Console.WriteLine("I'm flying!!");
        }
    }
}
