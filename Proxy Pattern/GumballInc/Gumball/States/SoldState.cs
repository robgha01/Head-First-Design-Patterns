using System;

namespace GumballInc.Gumball.States
{
    public class SoldStateState : StateBase
    {
        public SoldStateState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("Please Wait, we're already giving you a gumball");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public override void Dispense()
        {
            GumballMachine.ReleaseBall();
            
            if(GumballMachine.GetCount() > 0)
            {
                GumballMachine.SetState(GumballMachine.GetNoQuarterState());
            }
            else
            {
                GumballMachine.SetState(GumballMachine.GetSoldOutState());
            }
        }

        public override string ToString()
        {
            return "SoldState";
        }
    }
}
