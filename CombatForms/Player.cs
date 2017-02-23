using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{
    //Name: Player
    //Type: Class
    class Player : IDamageable
    {
        private string Name;
        private Stats PlayerStats;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private bool Alive;
        private bool Active;

        enum PlayerStates
        {
            init, idle, attack, dead, exit
        }

        FSM<PlayerStates> PlayerFSM;

        public Player() { }
        public Player(string n, Stats p, Element w, Element r, Element a)
        {
            Name = n; PlayerStats = p;
            Weakness = w; Resistance = r; AttackType = a;
            PlayerFSM = new FSM<PlayerStates>();
        }

        public void CheckifAlive()
        {

        }
        public void Activate()
        {
            Active = true;
        }
        public void Deactivate()
        {
            Active = false;
        }
        //Name: IDamageable.Damage
        //Type: void
        //Description: triggers the TakeDamage function
        void IDamageable.Damage(int damage)
        {
            PlayerStats.TakeDamage(damage);
        }
    }
}
