using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSim
{


    public abstract class AMonster
    {
        public float Health { get; protected set; }
        public float Attack { get; protected set; }
        public float Defense { get; protected set; }
        public float Speed { get; protected set; }

        public enum Race
        {
            ORC, TROLL, GOBLIN
        }

        public AMonster(float health, float attack, float defense, float speed)
        {
            this.Health = health;
            this.Attack = attack;
            this.Defense = defense;
            this.Speed = speed;
        }
        public virtual void DoDamage(AMonster monster)
        {
            monster.TakeDamage(monster);
        }

        public virtual void TakeDamage(AMonster monster)
        {
            Health -= monster.Attack;
        }
    }

    public class Orc : AMonster
    {
        public Orc(float health, float attack, float defense, float speed) : base(health, attack, defense, speed)
        {
        }     
    }

    public class Troll : AMonster
    {
        public Troll(float health, float attack, float defense, float speed) : base(health, attack, defense, speed)
        {
        }
    }

    public class Goblin : AMonster
    {
        public Goblin(float health, float attack, float defense, float speed) : base(health, attack, defense, speed)
        {
        }    
    }
}
