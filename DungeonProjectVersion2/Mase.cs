using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProjectVersion2
{
    class Mase:Weapon
    {
        public Mase(Game game, Point location)
            : base(game, location)
        { }

        public override string Name { get { return "Mase"; } }

        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
        }
    }
}
