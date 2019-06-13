using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunglePath
{
    class Player
    {
        public int x, y, lives, current;        
        public int size = 65;
        public string direction;

        public Player(int _x, int _y, int _lives, string _direction)
        {
            x = _x;
            y = _y;
            lives = _lives;
            direction = _direction;
        }

        public void move(Block b)
        {
            x = b.x;
            y = b.y;
        }
    }
}
