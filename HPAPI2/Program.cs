using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPAPI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100, 3, "Player");
            Enemy enemy = new Enemy(50, 3, "Enemy");
            player.ShowStats();
            player.TakeDMG(50);
            player.ShowStats();
            player.Heal(25);
            player.ShowStats();
            player.TakeDMG(100);
            player.ShowStats();
            player.Heal(25);
            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            enemy.ShowStats();
            enemy.TakeDMG(25);
            enemy.ShowStats();
            enemy.Heal(10);
            enemy.ShowStats();
            enemy.TakeDMG(50);
            enemy.ShowStats();
            enemy.Heal(25);
            enemy.ShowStats();
            Console.ReadKey(true);
        }





    }
}
