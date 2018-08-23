using System;
using GumballInc.Gumball;

namespace GumballInc
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 500;

            var gumballMachine = new GumballMachine("500", count);
            var monitor = new GumballMonitor(gumballMachine);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            monitor.Report();
        }
    }
}
