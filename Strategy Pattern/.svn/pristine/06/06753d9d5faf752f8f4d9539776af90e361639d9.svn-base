using System;
using MiniDuckSimulator.DuckSim.Behaviors.Fly;
using MiniDuckSimulator.DuckSim.Behaviors.Quack;

namespace MiniDuckSimulator.DuckSim.Species
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
