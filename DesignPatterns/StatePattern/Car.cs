using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
     class Car
    {
        // 
        public State state = State.Stopped;

        public State CurrentState { get { return state; } }

        public enum State
        {
            Stopped,
            Started,
            Running
        }
        public enum Action
        {
            Start,
            Stop,
            Accelarate
        }

        public void TakeAction(Action action)
        {
            switch ((state, action))
            {
                case (State.Stopped, Action.Start): state = State.Started; break;
                case (State.Started, Action.Accelarate): state = State.Running; break;
                case (State.Started, Action.Stop): state = State.Stopped; break;
                case (State.Running, Action.Stop): state = State.Stopped; break;
                default: break;
            }
        }
    }
}
