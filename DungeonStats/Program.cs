using System;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
        }
        private static int Damage(int attack, int defense)
        {
            return attack - defense;
        }
        private static int Damage(int attack)
        {
            return attack;
        }
        private static int CriticalHit(int damage)
        {
            if (damage == 1)
            {
                return 1;
            }
            else
            {
              return damage + CriticalHit(damage - 1);  
            }
        }
    }
}
