using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    //Name: Column
    //Type: class
    //Description: Contains a single 
    class Column<T>
    {
        private Player PlayerSlot;
        private Demon DemonSlot;
        private T Active;

        public Column() { }
        public Column(Player p, Demon d)
        {
            PlayerSlot = p;
            DemonSlot = d;
        }
        public void SetActive (T targetable)
        {
            Active = targetable;
        }
    }

    class FSM
    {
        //GameStart -> TurnStart: Automatic, when the Program starts
        //TurnStart -> PlayerTurn: when a button is pressed
        //PlayerTurn -> 
    }
    
}
