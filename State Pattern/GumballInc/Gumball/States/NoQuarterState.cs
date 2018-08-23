using System;

namespace GumballInc.Gumball.States
{
    public class NoQuarterState : StateBase
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine) {}

        public override void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            GumballMachine.SetState(GumballMachine.GetHasQuarterState());
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned but there's no quarter");
        }

        public override void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override string ToString()
        {
            return "NoQuarterState";
        }
    }
}
