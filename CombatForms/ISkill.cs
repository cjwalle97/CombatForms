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
    interface ISkill<T>
    {
        void SkillTarget(T target);
    }
    //Name: ICastSkills
    //Type: interface
    //Description : allows Players and Demon's to to cast skills by accessing a list
    interface ICastSkills<T>
    {
        List<T> SkillList();
    }

    class FireSkill<T> : ISkill<T>
    {
        private string Name = "Agi";
        private float Cost = 8;
        private Element Type = 0;
        private T Target;

        public FireSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class IceSkill<T> : ISkill<T>
    {
        private string Name = "Bufu";
        private float Cost = 8;
        private Element Type = (Element)1;
        private T Target;

        public IceSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class ElectricitySkill<T> : ISkill<T>
    {
        private string Name = "Zio";
        private float Cost = 8;
        private Element Type = (Element)2;
        private T Target;

        public ElectricitySkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class ForceSkill<T> : ISkill<T>
    {
        private string Name = "Zan";
        private float Cost = 8;
        private Element Type = (Element)3;
        private T Target;

        public ForceSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class DarkSkill<T> : ISkill<T>
    {
        private string Name = "Mudo";
        private float Cost = 8;
        private Element Type = (Element)4;
        private T Target;

        public DarkSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }

    class LightSkill<T> : ISkill<T>
    {
        private string Name = "Hama";
        private float Cost = 8;
        private Element Type = (Element)5;
        private T Target;

        public LightSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class SlashSkill<T> : ISkill<T>
    {
        private string Name = "Cut";
        private float Cost = 8;
        private Element Type = (Element)6;
        private T Target;

        public SlashSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class StrikeSkill<T> : ISkill<T>
    {
        private string Name = "Bash";
        private float Cost = 8;
        private Element Type = (Element)7;
        private T Target;

        public StrikeSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    class PierceSkill<T> : ISkill<T>
    {
        private string Name = "Needle shot";
        private float Cost = 8;
        private Element Type = (Element)8;
        private T Target;

        public PierceSkill() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }

}
