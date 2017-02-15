using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public enum TurnStates
    {
        //TurnBegin: will update the UI before starting the current player's turn
        TurnBegin = 0,
        //PlayerTurn: will receive the commands for the current Player
        PlayerTurn = 1,
        //TurnEnd: will execute the inputted commands before moving the current Player to the next Player in the Party
        //or moving on to the first Player of the next Party
        TurnEnd = 2,
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
    }
    //Name: Column
    //Type: class
    //Description: 
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
        
    }
    
}
