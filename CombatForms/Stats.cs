using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    public class Stats 
    {
        private float HP;
        private float MP;
        private float STR;
        private float MAG;
        private float DEX;
        private float AGI;
        private float LUC;

        public Stats(float h, float m, float s, float i, float d, float a, float l) {
            HP = h; MP = m; STR = s; MAG = i; DEX = d; AGI = a; LUC = l;
        }
        //Name: TakeDamage
        //Type: void
        //Description: subtracts a float from HP
        public void TakeDamage(float damage)
        {
            HP -= damage;
        }
        //Name: PayCost
        //Type: void
        //Description: subtracts a float from MP 
        public void PayCost(float cost)
        {
            MP -= cost;
        }
        //Name: AccessSTR
        //Type: float
        //Description: allows for easy access to the STR stat
        public float AccessSTR()
        {
            float stat = STR;
            return stat;
        }
        //Name: AccessMAG
        //Type: float
        //Description: allows for easy access to the MAG stat
        public float AccessMAG()
        {
            float stat = MAG;
            return stat;
        }
        //Name: AccessDEX
        //Type: float
        //Description: allows for easy access to the DEX stat
        public float AccessDEX()
        {
            float stat = DEX;
            return stat;
        }
    }
}
