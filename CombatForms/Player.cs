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
    //Description: determines what element a Skill/Attack is, should a 
    public enum Element
    {
        Fire = 0,
        Ice = 1,
        Electricity = 2,
        Force = 3,
        Dark = 4,
        Light = 5,
        Slash = 6,
        Pierce = 7,
        Strike = 8,
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
        void IDamageable.Damage(float damage)
        {
            PlayerStats.TakeDamage(damage);
        }
    }

    //Name: Demon
    //Type: Class
    class Demon : Player, IDamageable//, ICastSkills<T>
    {
        private string Name;
        private Stats DemonStats;
        private Element Weakness;
        private Element Resistance;
        private Element AttackType;
        private Player Summoner;

        public Demon() { }
        public Demon(string n, Element w, Element r, Element a, Player s)
        {
            Name = n; Weakness = w; Resistance = r; AttackType = a; Summoner = s;
        }
        void IDamageable.Damage(float damage)
        {
            DemonStats.TakeDamage(damage);
        }
    }
}
