using System;
using MiniDuckSimulator.DuckSim.Behaviors.Fly;
using MiniDuckSimulator.DuckSim.Behaviors.Quack;

namespace MiniDuckSimulator.DuckSim.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
