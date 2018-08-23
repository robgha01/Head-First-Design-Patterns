using GumballInc.Gumball.Abstraction;

namespace GumballInc.Gumball
{
    public abstract class StateBase : IState
    {
        protected readonly GumballMachine GumballMachine;

        protected StateBase(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public abstract void InsertQuarter();
        public abstract void EjectQuarter();
        public abstract void TurnCrank();
        public abstract void Dispense();
        public abstract override string ToString();
    }
}
