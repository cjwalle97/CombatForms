using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CombatForms
{
    //Name: Element
    //Type: enum
    //Description: determines what element a Skill/Attack is
    public enum Element
    {
        Fire = 0,
        Ice = 1,
        Electricity = 2,
        Force = 3,
        Dark = 4,
        Light = 5,
        Slash = 6,
        Strike = 7,
        Pierce = 8,
    }
    //Name: Player
    //Type: Class
    class Player : IDamageable//, ICastSkills<T>
    {
        private string Name;
        private Stats PlayerStats;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private bool Alive;

        public Player() { }
        public Player(string n, Stats p, Element w, Element r, Element a)
        {
            Name = n; PlayerStats = p;
            Weakness = w; Resistance = r; AttackType = a;
        }
        //Name: IDamageable.Damage
        //Type: void
        //Description: triggers the TakeDamage function
        void IDamageable.Damage(float damage)
        {
            PlayerStats.TakeDamage(damage);
        }
    }

    //Name: Demon
    //Type: Class
    class Demon : IDamageable//, ICastSkills<T>
    {
        private string Name;
        private Stats DemonStats;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private bool Alive;

        public Demon() { }
        public Demon(string n, Stats s ,Element w, Element r, Element a)
        {
            Name = n; DemonStats = s;  Weakness = w; Resistance = r; AttackType = a;
        }
        //Name: IDamageable.Damage
        //Type: void
        //Description: triggers the TakeDamage function
        void IDamageable.Damage(float damage)
        {
            DemonStats.TakeDamage(damage);
        }

    }
}
