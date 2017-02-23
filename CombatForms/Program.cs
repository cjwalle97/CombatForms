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
        class StateBehavior
        {
            static public void TurnBeginBehavior()
            {

            }
            static public void TurnEndBehavior()
            {

            }
        }
        public delegate void Handler();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        enum TestState
        {
            init, idle, exit,
        }
        [STAThread]
        static void Main()
        {
            //State GameStart = new State(TurnState.GameStart);
            //State TurnBegin = new State(TurnState.TurnBegin);
            //State PlayerTurn = new State(TurnState.PlayerTurn);
            //State TurnEnd = new State(TurnState.TurnEnd);
            //State GameEnd = new State(TurnState.GameEnd);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //FSM<Enum> fsm = new FSM<Enum>();

            //fsm.AddTransition(GameStart, TurnBegin);
            //fsm.AddTransition(TurnBegin, PlayerTurn);
            //fsm.AddTransition(PlayerTurn, TurnEnd);
            //fsm.AddTransition(TurnEnd, TurnBegin);
            //fsm.AddTransition(TurnEnd, GameEnd);
            //fsm.AddTransition(TurnBegin, GameEnd);
            //fsm.AddTransition(PlayerTurn, GameEnd);

            //fsm.GetState(TurnState.TurnBegin).AddEnterFunction((Handler)StateBehavior.TurnBeginBehavior);
            //fsm.GetState(TurnState.PlayerTurn).AddEnterFunction((Handler)StateBehavior.PlayerTurnBehavior);
            //fsm.GetState(TurnState.TurnEnd).AddEnterFunction((Handler)StateBehavior.TurnEndBehavior);

            FSM<TestState> Test = new FSM<TestState>();

            Test.AddTransition(TestState.init.ToString(), Test.GetState(TestState.idle));
            Test.AddTransition(TestState.idle.ToString(), Test.GetState(TestState.exit));

            Test.ChangeState(Test.GetState(TestState.exit));
            Test.ChangeState(Test.GetState(TestState.idle));
            Test.ChangeState(Test.GetState(TestState.init));
            Test.ChangeState(Test.GetState(TestState.exit));
        }

    }
}
