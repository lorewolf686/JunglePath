using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunglePath
{
    public class Block
    {
        public int x, y;
        public int size = 65;
        public bool select, revealed;
        public string type;
        public Block(int _x, int _y, bool _select, bool _revealed, string _type)
        {
            x = _x;
            y = _y;
            select = _select;
            revealed = _revealed;
            type = _type;
        }

        public bool SelectCheck()
        {
            if(select == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }              
        public string Check ()
        {            
            switch  (type)
            {
                case "monster":
                    return "lose";
                    
                case "win":
                    return "win";
                    
                case "path":
                    return "safe";

                default:
                    return null;
            }
        }
    }
    


}
