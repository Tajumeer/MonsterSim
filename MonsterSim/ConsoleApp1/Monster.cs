﻿using System;
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
            Console.WriteLine("Set the {0}'s Attackpoints", Race.ToString());
            float.TryParse(Console.ReadLine(), out this.attack);
            Console.WriteLine("Set the {0}'s Defensepoints", Race.ToString());
            float.TryParse(Console.ReadLine(), out this.defense);
            Console.WriteLine("Set the {0}'s Speed", Race.ToString());
            float.TryParse(Console.ReadLine(), out this.speed);
            Console.WriteLine("The {0} has {1} HP, {2} AP, {3} DP, and is {4} fast",Race.ToString(), health, attack, defense, speed);
            Console.WriteLine("--------------------");
            Console.WriteLine("Choose the second Monster.\nPress 1 to Choose an Orc\nPress 2 to Choose an Troll\nPress 3 to Choose an Goblin\nMonsters of the same Race cant fight amongst each other!");
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

    public class Monster:AMonster
    { 
        public Monster(int race):base(race)
        {   
            
        }
    }
}

