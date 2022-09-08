using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
    /*
     * Quản lý các hình ảnh được load lên từ máy
     */
    static class SpriteHandler
    {
        public static Image Cell;
        public static Image CellOffSet;
        public static Image Highlight;
        public static Image CellChecked;
        public static Image CellCheckedOffset;
        public static Image Mine;
        public static Image One;
        public static Image Two;
        public static Image Three;
        public static Image Four;
        public static Image Five;
        public static Image Six;
        public static Image Seven;
        public static Image Eight;
        public static Image Flag;
        public static Image Blasted;
        public static Image BlastedOffset;
        public static Image MineExploded;
        static SpriteHandler()
        {
            Cell = Image.FromFile("assets/cell.png");
            CellOffSet = Image.FromFile("assets/cell-offset.png");
            Highlight = Image.FromFile("assets/highlight.png");
            CellCheckedOffset = Image.FromFile("assets/cell-checked-offset.png");
            CellChecked = Image.FromFile("assets/cell-checked.png");
            Mine = Image.FromFile("assets/mine.png");
            One = Image.FromFile("assets/1.png");
            Two = Image.FromFile("assets/2.png");
            Three = Image.FromFile("assets/3.png");
            Four = Image.FromFile("assets/4.png");
            Five = Image.FromFile("assets/5.png");
            Six = Image.FromFile("assets/6.png");
            Seven = Image.FromFile("assets/7.png");
            Eight = Image.FromFile("assets/8.png");
            Flag = Image.FromFile("assets/flag.png");
            Blasted = Image.FromFile("assets/blasted.png");
            BlastedOffset = Image.FromFile("assets/blasted-offset.png");
            MineExploded = Image.FromFile("assets/mine-exploded.png");
        }
        /*
         * Phương thức lấy hình ảnh dựa trên số mìn lân cận
         */
        public static Image GetCount(int count)
        {
            switch (count)
            {
                case 1:
                    return One;
                case 2:
                    return Two;
                case 3:
                    return Three;
                case 4:
                    return Four;
                case 5:
                    return Five;
                case 6:
                    return Six;
                case 7:
                    return Seven;
                case 8:
                    return Eight;
                default:
                    return null;
            }
        }
    }
}
