using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CombatForms
{
    class Program
    {
        //static public State TurnBegin((TurnStates)1);

        class StateBehavior
        {
            public void TurnBeginBehavior()
            {
                
            }
            public void PlayerTurnBehavior()
            {

            }
            public void TurnEndBehavior()
            {

            }
        }
        public delegate void Handler();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            FSM<TurnStates> fsm = new FSM<TurnStates>();

        }
    }
}
