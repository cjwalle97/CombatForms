using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public enum States
    {
        //TurnBegin: will update the UI before starting the current player's turn
        TurnBegin = 0,
        //PlayerTurn: will receive the commands for the current Player
        PlayerTurn = 1,
        //TurnEnd: will execute the inputted commands before moving the current Player to the next Player in the Party
        //or moving on to the first Player of the next Party
        TurnEnd = 2,
    }
    class FSM
    {
        
    }
    
}
