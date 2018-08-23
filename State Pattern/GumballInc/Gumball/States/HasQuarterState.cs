using System;

namespace GumballInc.Gumball.States
{
    public class HasQuarterState : StateBase
    {
        Random randomWinner = new Random(Environment.TickCount);
        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine) {}

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            GumballMachine.SetState(GumballMachine.GetNoQuarterState());
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned...");

            int winner = randomWinner.Next(10);
            if(winner == 0 && GumballMachine.GetCount() > 1)
            {
                GumballMachine.SetState(GumballMachine.GetWinnerState());
            }
            else
            {
                GumballMachine.SetState(GumballMachine.GetSoldState());
            }

            GumballMachine.SetState(GumballMachine.GetSoldState());
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "HasQuarter";
        }
    }
}
