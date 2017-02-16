using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{
    public enum TurnStates
    {
        //GameStart: will start the game before moving on to TurnBegin
        GameStart = 0,
        //TurnBegin: will update the UI before starting the current player's turn
        TurnBegin = 1,
        //PlayerTurn: will receive the commands for the current Player
        PlayerTurn = 2,
        //TurnEnd: will execute the inputted commands before moving the current Player to the next Player in the Party
        //or moving on to the first Player of the next Party
        TurnEnd = 3,
        //GameEnd: will end the game
        GameEnd =9000,
    }

    class State
    {
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();
        }
        public string name;
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;
        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }
        public void AddExitFunction(Delegate d)
        {
            onExit += d as OnExit;
        }
    }

    class FSM<T>
    {
        //GameStart -> TurnStart: Automatic, when the Program starts
        //TurnStart -> PlayerTurn: when a button is pressed
        //PlayerTurn -> TurnEnd: Automatic, when the code connected to the button executes
        //TurnEnd -> TurnStart: Automatic, when the UI updates
        // any state -> GameEnd: if either the quit game button is used or all Columns of one party are dead
        public FSM()
        {
            states = new Dictionary<string, State>();
            var v = Enum.GetValues(typeof(T));
            foreach (var e in v)
            {
                State s = new State(e as Enum);
                states.Add(s.name, s);
            }
        }
        Dictionary<string, State> states;
        State cState;
        public void  ChangeState(State state)
        {
            if(isValidTransition(state))
            {
                cState.onExit();
                cState = state;
                cState.onEnter();
            }
        }
        public void AddTransition(State a, State b)
        {
            cState = a;
            ChangeState(b);
        }
        public State GetState(T e)
        {
            string key = (e as State).name;
            return states[key];
        }

        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();
        private bool isValidTransition(State to)
        {
            var validStates = transitions[cState.name];
            if(validStates == null)
            {
                return false;
            }
            foreach (var state in validStates)
            {
                if (state == to)
                {
                    return true;
                }
               
            }
            return false;
        }
        public bool Start()
        {
            return true;
        }
        public bool Update()
        {
            return true;
        }
    }
}
