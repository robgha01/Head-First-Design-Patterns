using System;

namespace GumballInc.Gumball
{
    public class GumballMonitor
    {
        private readonly GumballMachine _gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine(string.Format("Gumball Machine: {0}", _gumballMachine.GetLocation()));
            Console.WriteLine(string.Format("Current inventory: {0}", _gumballMachine.GetCount()));
            Console.WriteLine(string.Format("Current state: {0}", _gumballMachine.GetState()));
        }
    }
}
