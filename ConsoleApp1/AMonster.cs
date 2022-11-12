using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MonsterSim.AMonster;

namespace MonsterSim
{


    public abstract class AMonster
    {
        public enum MonsterRace
        {
            Orc = 1, Troll = 2, Goblin = 3
        }
        public MonsterRace Race;

        Random crit = new Random();

        private float health;
        private float attack;
        private float defense;
        private float speed;

        public float Health { get { return health; } protected set { health = value; } }
        public float Attack { get { return attack; } protected set { attack = value; } }
        public float Defense { get { return defense; } protected set { defense = value; } }
        public float Speed { get { return speed; } protected set { speed = value; } }

        public AMonster(int race)
        {
            Race = (MonsterRace)race;
            Console.WriteLine("Set the {0}'s Healthpoints", Race.ToString());
            float.TryParse(Console.ReadLine(),out this.health);
            while (this.health <= 0)
            {
                Console.WriteLine("Enter a numerical value above 0");
                float.TryParse(Console.ReadLine(), out this.health);
            }

            Console.WriteLine("Set the {0}'s Attackpoints", Race.ToString());
            float.TryParse(Console.ReadLine(), out this.attack);
            while (this.attack <= 0)
            {
                Console.WriteLine("Enter a numerical value above 0");
                float.TryParse(Console.ReadLine(), out this.attack);
            }
            Console.WriteLine("Set the {0}'s Defensepoints", Race.ToString());
            float.TryParse(Console.ReadLine(), out this.defense);
            while (this.defense <= 0)
            {
                Console.WriteLine("Enter a numerical value above 0");
                float.TryParse(Console.ReadLine(), out this.defense);
            }
            Console.WriteLine("Set the {0}'s Speed", Race.ToString());
            float.TryParse(Console.ReadLine(), out this.speed);
            while (this.speed <= 0)
            {
                Console.WriteLine("Enter a numerical value above 0");
                float.TryParse(Console.ReadLine(), out this.speed);
            }     
            Console.WriteLine("The {0} has {1} HP, {2} AP, {3} DP, and is {4} fast",Race.ToString(), health, attack, defense, speed);
            Console.WriteLine("--------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }

        
        public virtual void DoDamage(AMonster attacker, AMonster defender)
        {
            float Damage = attacker.attack - defender.defense;
            if (Damage <= 0)
                Damage = 1;
            int CriticalDamage = crit.Next(0, 100);
            if (CriticalDamage >= 80)
            {
                Damage *= 2;
                Console.Write("The Attacking {0} hits the Defending {1}", attacker.Race, defender.Race);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" for {0} Critical Damage!!!\n", Damage);
                Console.ResetColor();
            }
            else Console.WriteLine("The Attacking {0} hits the Defending {1} for {2} Damage",attacker.Race, defender.Race, Damage);
            defender.health -= Damage;
        }
    }

    public class Monster:AMonster
    { 
        public Monster(int race):base(race)
        {
            
        }
    }
}

