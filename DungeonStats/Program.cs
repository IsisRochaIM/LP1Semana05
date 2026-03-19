using System;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int val1 = int.Parse(args[0]);
            int val2;

            int damage1 = Damage(val1);
            if (args.Length >= 2)
            {
                val2 = int.Parse(args[1]);
            }
            else
            {
                val2 = 2;
            }
            
            
            int damage2 = Damage(val1, val2);
            
            int critDamage = CriticalHit(damage2);

            var table = new Table();
            table.AddColumn("Operation");
            table.AddColumn("Result");

            table.AddRow($"Damage({val1})", $"{damage1}");
            table.AddRow($"Damage({val1}, {val2})", $"{damage2}");
            table.AddRow($"CriticalHit({damage2})", $"{critDamage}");

            AnsiConsole.Write(table);
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
