using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Stats 
    {
        public int HP;
        public int MP;
        public float STR;
        public float MAG;
        public float DEX;
        public float AGI;
        public float LUC;

        public Stats(int h, int m, int s, int i, int d, int a, int l) {
            HP = h; MP = m; STR = s; MAG = i; DEX = d; AGI = a; LUC = l;
        }
        //Name: TakeDamage
        //Type: void
        //Description: subtracts a float from HP
        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
        //Name: PayCost
        //Type: void
        //Description: subtracts a float from MP 
        public void PayCost(int cost)
        {
            MP -= cost;
        }
    }
}
