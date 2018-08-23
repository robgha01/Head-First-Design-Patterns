using System;
using MiniDuckSimulator.DuckSim.Interfaces.Behaviors;

namespace MiniDuckSimulator.DuckSim
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        protected Duck()
        {
            
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("AA ducks float, even decoys!");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }
    }
}
