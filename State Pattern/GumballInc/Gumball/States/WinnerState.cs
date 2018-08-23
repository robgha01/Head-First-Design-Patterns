using System;

namespace GumballInc.Gumball.States
{
    public class WinnerState : StateBase
    {
        public WinnerState(GumballMachine gumballMachine) : base(gumballMachine) { }

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
            Console.WriteLine("YOU ARE A WINNER! You get two gumballs for youre quarter");
            GumballMachine.ReleaseBall();

            if(GumballMachine.GetCount() == 0)
            {
                GumballMachine.SetState(GumballMachine.GetSoldOutState());
            }
            else
            {
                GumballMachine.ReleaseBall();
                if(GumballMachine.GetCount() > 0)
                {
                    GumballMachine.SetState(GumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops out of gumballs!");
                    GumballMachine.SetState(GumballMachine.GetSoldOutState());
                }
            }

        }

        public override string ToString()
        {
            return "WinnerState";
        }
    }
}
