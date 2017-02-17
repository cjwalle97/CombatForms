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

    //Name: Agi
    //Type: class
    //Description: a Skill with the Element of Fire that can be used by the Players and Demons
    class Agi<T> : ISkill<T>
    {
        private string Name = "Agi";
        private float Cost = 8;
        private Element Type = 0;
        private T Target;

        public Agi() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: Bufu
    //Type: class
    //Description: a Skill with the Element of Ice that can be used by the Players and Demons
    class Bufu<T> : ISkill<T>
    {
        private string Name = "Bufu";
        private float Cost = 8;
        private Element Type = (Element)1;
        private float Damage;
        private T Target;

        public Bufu() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: Zio
    //Type: class
    //Description: a Skill with the Element of Electricity that can be used by the Players and Demons
    class Zio<T> : ISkill<T>
    {
        private string Name = "Zio";
        private float Cost = 8;
        private Element Type = (Element)2;
        private T Target;

        public Zio() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: ForceSkills
    //Type: class
    //Description: a Skill with the Element of Force that can be used by the Players and Demons
    class Zan<T> : ISkill<T>
    {
        private string Name = "Zan";
        private float Cost = 8;
        private Element Type = (Element)3;
        private T Target;

        public Zan() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: Mudo
    //Type: class
    //Description: a Skill with the Element of Dark that can be used by Players and Demons
    class Mudo<T> : ISkill<T>
    {
        private string Name = "Mudo";
        private float Cost = 8;
        private Element Type = (Element)4;
        private T Target;

        public Mudo() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }

    //Name: Hama
    //Type: class
    //Description: a Skill with the Element of Light that can be used by the Players and Demons
    class Hama<T> : ISkill<T>
    {
        private string Name = "Hama";
        private float Cost = 8;
        private Element Type = (Element)5;
        private T Target;

        public Hama() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: GramSlice
    //Type: class
    //Description: a Skill with the Element of Slash that can be used by the Players and Demons
    class GramSlice<T> : ISkill<T>
    {
        private string Name = "Gram Slice";
        private float Cost = 8;
        private Element Type = (Element)6;
        private T Target;
        
        public GramSlice() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: StrikeSkill
    //Type: class
    //Description: a Skill with the Element of Strike that both the Players and Demons can use
    class Lunge<T> : ISkill<T>
    {
        private string Name = "Lunge";
        private float Cost = 8;
        private Element Type = (Element)7;
        private T Target;

        public Lunge() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }
    //Name: NeedleShot
    //Type: class
    //Description: A skill with the Pierce Element that the Players and Demons can use
    class NeedleShot<T> : ISkill<T>
    {
        private string Name = "Needle shot";
        private float Cost = 8;
        private Element Type = (Element)8;
        private T Target;

        public NeedleShot() { }
        void ISkill<T>.SkillTarget(T target)
        {
            Target = target;
        }
    }

}
