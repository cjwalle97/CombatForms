using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    //Name: Column
    //Type: class
    //Description: a unit that represents a Player and a Demon
    class Column
    {
        private Player PlayerSlot;
        private Demon DemonSlot;

        enum ColumnStates
        {
            init, enter, select, exit
        }

        FSM<ColumnStates> ColumnFSM;


        public Column() { }
        public Column(Player p, Demon d)
        {
            PlayerSlot = p;
            DemonSlot = d;
        }
    }
}
