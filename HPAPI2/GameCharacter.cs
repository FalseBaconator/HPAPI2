using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPAPI2
{
    internal class GameCharacter
    {

        int HP;
        int maxHP;
        int Lives;
        string Name;


        public GameCharacter(int hP = 100, int lives = 3, string name = "name")
        {
            HP = hP;
            maxHP = hP;
            Lives = lives;
            Name = name;
        }

        public void TakeDMG(int dmg)
        {
            Console.WriteLine("take " + dmg + " dmg");
            HP -= dmg;
            if (HP <= 0 && Lives > 0)
            {
                Lives--;
                HP = maxHP;
            }
            else if (HP <= 0)
            {
                Console.WriteLine("player has died");
            }
        }

        public void Heal(int heal)
        {
            Console.WriteLine("gain " + heal + " health");
            HP += heal;
            if (HP > maxHP) HP = maxHP;
        }

        public void ShowStats()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine(Name);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("---------------------------");
        }
    }
}
