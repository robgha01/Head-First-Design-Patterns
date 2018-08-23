using System;
using GumballInc.Gumball.Abstraction;
using GumballInc.Gumball.States;

namespace GumballInc.Gumball
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;

        private IState _state;
        private int _count;
        private string _location;

        public GumballMachine(string location, int count)
        {
            // set the default state of the machine
            _state = _soldOutState;

            // set the state behaviors
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldStateState(this);
            _winnerState = new WinnerState(this);

            _count = count;

            if(count > 0)
            {
                _state = _noQuarterState;
            }

            _location = location;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void Refill(int count)
        {
            _count += count;
            _state = _noQuarterState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");

            if(_count != 0)
            {
                _count--;
            }
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public int GetCount()
        {
            return _count;
        }
		
		public IState GetState()
        {
            return _state;
        }

        public string GetLocation()
        {
            return _location;
        }

        public override string ToString()
        {
            return string.Format("State: {0} | Gumballs: {1}", _state, _count);
        }
    }
}
