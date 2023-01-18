using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPAPI2
{
    internal class Enemy : GameCharacter
    {


        public Enemy(int HP = 100, int Lives = 3, string Name = "name") : base(HP, Lives, Name)
        {

        }
    }
}
