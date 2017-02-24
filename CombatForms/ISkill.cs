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
        void Damage(int damage);
    }
    //Name: ISkill
    //Type: Interface
    //Description: determines that the class is a skill
    interface ISkill<T>
    {
        void SkillCaster(T caster);
    }

    //Name: Agi
    //Type: class
    //Description: a Skill with the Element of Fire that can be used by the Players and Demons
    class Agi<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Agi";
        public float Cost = 8;
        public Element Type = Element.Fire;
        public Agi() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: Bufu
    //Type: class
    //Description: a Skill with the Element of Ice that can be used by the Players and Demons
    class Bufu<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Bufu";
        public float Cost = 8;
        public Element Type = Element.Ice;
        public Bufu() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: Zio
    //Type: class
    //Description: a Skill with the Element of Electricity that can be used by the Players and Demons
    class Zio<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Zio";
        public float Cost = 8;
        public Element Type = Element.Electricity;
        public Zio() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: Zan
    //Type: class
    //Description: a Skill with the Element of Force that can be used by the Players and Demons
    class Zan<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Zan";
        public float Cost = 8;
        public Element Type = Element.Force;
        public Zan() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: Mudo
    //Type: class
    //Description: a Skill with the Element of Dark that can be used by Players and Demons
    class Mudo<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Mudo";
        public float Cost = 8;
        public Element Type = Element.Dark;
        public Mudo() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }

    //Name: Hama
    //Type: class
    //Description: a Skill with the Element of Light that can be used by the Players and Demons
    class Hama<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Hama";
        public float Cost = 8;
        public Element Type = Element.Light;
        public Hama() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: GramSlice
    //Type: class
    //Description: a Skill with the Element of Slash that can be used by the Players and Demons
    class GramSlice<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Gram Slice";
        public float Cost = 8;
        public Element Type = Element.Slash;
        public GramSlice() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: Lunge
    //Type: class
    //Description: a Skill with the Element of Strike that both the Players and Demons can use
    class Lunge<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Lunge";
        public float Cost = 8;
        public Element Type = Element.Strike;
        public Lunge() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }
    //Name: NeedleShot
    //Type: class
    //Description: A skill with the Pierce Element that the Players and Demons can use
    class NeedleShot<T> : ISkill<T>
    {
        private T Caster;

        public string Name = "Needle Shot";
        public float Cost = 8;
        public Element Type = Element.Pierce;
        public NeedleShot() { }
        void ISkill<T>.SkillCaster(T caster)
        {
            Caster = caster;
        }
    }

}
