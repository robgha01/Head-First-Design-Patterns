using System;

namespace GumballInc.Gumball.States
{
    public class SoldOutState : StateBase
    {
        public SoldOutState(GumballMachine gumballMachine) : base(gumballMachine) {}

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned but there is no gumballs");
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "SoldOutState";
        }
    }
}
