using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{ 
    //Name: Demon
    //Type: Class
    class Demon : IDamageable
    {
        private string Name;
        private Stats DemonStats;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private bool Alive;
        private bool Active;

        enum DemonStates
        {
            init, idle, attack, dead, exit
        }

        FSM<DemonStates> DemonFSM;

        public Demon() { }
        public Demon(string n, Stats d, Element w, Element r, Element a)
        {
            Name = n;
            DemonStats = d;
            Weakness = w;
            Resistance = r;
            AttackType = a;
            DemonFSM = new FSM<DemonStates>();
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
            if (Active == true)
            {
                DemonStats.TakeDamage(damage);
            }
        }
    }
}
