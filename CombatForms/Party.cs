using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    //Name: Party
    //Type: class
    //Description: A unit that represents three Columns
    class Party
    {
        private Column Center;
        private Column Right;
        private Column Left;

        enum PartyStates
        {
            init, enter, idle, exit,
        }


        FSM<PartyStates> PartyFSM;

        public Party(Column c, Column r, Column l)
        {
            Center = c;
            Right = r;
            Left = l;
            PartyFSM = new FSM<PartyStates>();
        }
    }
}
