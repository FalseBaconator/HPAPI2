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
            Console.WriteLine("HP API 2.0");
            Player player = new Player(100, 3);
            player.ShowStats();
            player.TakeDMG(50);
            player.ShowStats();
            player.Heal(25);
            player.ShowStats();
            player.TakeDMG(100);
            player.ShowStats();
            Console.ReadKey(true);
        }





    }
}
