using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    /*
     * Coordinate là một custom key dùng để map vị trí của các cell
     */
    class Coordinate
    {
        //X Y là vị trí hàng và cột của một Cell
        public int X { get; private set; }
        public int Y { get; private set; }
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
        // Debugging
        public override string ToString()
        {
            return $"{X}:{Y}";
        }
        public override bool Equals(object obj)
        {
            return this.X == ((Coordinate)obj).X && this.Y == ((Coordinate)obj).Y;
        }
        public override int GetHashCode()
        {
            return this.X ^ this.Y;
        }
    }
}
