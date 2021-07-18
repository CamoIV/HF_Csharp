using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProjectVersion2
{
    class RedPotion:Weapon, Ipotion
    {
        public RedPotion(Game game, Point location)
            : base(game, location)
        { }

        bool Ipotion.Used => throw new NotImplementedException();

        public bool Used()
        {
            get { return true; }
        }
    }
}
