using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPAPI2
{
    internal class Player
    {
        int HP;
        int Lives;

        public Player(int hP = 100, int lives = 3)
        {
            HP = hP;
            Lives = lives;
        }

        public void TakeDMG(int dmg)
        {
            Console.WriteLine("take " + dmg + " dmg");
            HP -= dmg;
        }

        public void Heal(int heal)
        {
            Console.WriteLine("gain " + heal + " health");
            HP += heal;
        }

        public void ShowStats()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("---------------------------");
        }

    }
}
