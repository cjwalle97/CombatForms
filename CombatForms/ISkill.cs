using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    //Name: IDamagable
    //Type: Interface
    //Description: allows the Players and Demons to take damage
    public interface IDamageable
    {
        void Damage(float damage);
    }
    //Name: ISkill
    //Type: Interface
    //Description: 
    interface ISkill
    {
        void SkillTarget(Player target)
    }

    class Skill : ISkill
    {
        private string Name;
        private Element Type;
        private Player Target;

        public Skill() { }
        public Skill(string n, Element t)
        {
            Name = n; Type = t;
        }
        void ISkill.SkillTarget(Player target)
        {
            Target = target;
        }

    }
}
