using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
    /*
     * Các ô trên màng hình game được tổ chức bởi đối tượng Cell
     */
    class Cell
    {
        /*
         * _x và _y là vị trí hàng và vị trí cột
         * _bound là kích thước của ô đơn vị pixel
         */
        private int _x;
        private int _y;
        private int _bound;
        public int Bound { get { return _bound; } }
        private bool _isHovered;
        private bool _isClicked;
        public bool IsClick { get { return _isClicked; } }
        private bool _isOffSet;
        private bool _isMine;
        public bool IsMine { get { return _isMine; } }
        private bool _isFlagged;
        public bool IsFlagged { get { return _isFlagged; } }
        private int _mineCount;
        public int MineCount { get { return _mineCount; } }
        private bool _isExploded;
        public bool IsExploded { get { return _isExploded; } }
        public Cell (int x, int y, int bound)
        {
            _x = x;
            _y = y;
            _bound = bound;
            _isClicked = false;
            _isMine = false;
            _isHovered = false;
            _isFlagged = false;
            _isExploded = false;
        }
        public float GetActualX()
        {
            return _x * _bound;
        }
        public float GetActualY()
        {
            return _y * _bound;
        }
        public void Init(bool isOffset)
        {
            _isOffSet = isOffset;
        }
        public void InitMine()
        {
            _isMine = true;
        }
        public void InitMineCount(int count)
        {
            _mineCount = count;
        }
        public void IsHovering(Coordinate coordinate)
        {
            _isHovered = !_isClicked && _x == coordinate.X && _y == coordinate.Y;
        }
        public void Blasted()
        {
            _isClicked = true;
            _isExploded = true;
        }
        public bool Click()
        {
            if (_isClicked)
                return false;
            _isClicked = true;
            if (_isMine)
                _isExploded = true;
            return _isMine;
        }
        public void Show()
        {
            _isClicked = true;
        }
        public void ToggleFlag()
        {
            _isFlagged = !_isFlagged;
        }
        /*
         * Phương thức vẽ cell lên màng hình
         */
        public void Render(Graphics graphics)
        {
            
            if (!_isClicked)
            {
                if (_isOffSet) // draw ground
                    graphics.DrawImage(SpriteHandler.Cell, _x * _bound, _y * _bound, _bound, _bound);
                else
                    graphics.DrawImage(SpriteHandler.CellOffSet, _x * _bound, _y * _bound, _bound, _bound);
            }
            else
            {
                if (_isExploded) // draw ground
                {
                    if(_isOffSet)
                        graphics.DrawImage(SpriteHandler.Blasted, _x * _bound, _y * _bound, _bound, _bound);
                    else
                        graphics.DrawImage(SpriteHandler.BlastedOffset, _x * _bound, _y * _bound, _bound, _bound);
                }
                else
                if(_isOffSet)
                    graphics.DrawImage(SpriteHandler.CellChecked, _x * _bound, _y * _bound, _bound, _bound);
                else
                    graphics.DrawImage(SpriteHandler.CellCheckedOffset, _x * _bound, _y * _bound, _bound, _bound);

                if (_isMine) // draw mine
                {
                    if (!_isExploded)
                        graphics.DrawImage(SpriteHandler.Mine, _x * _bound, _y * _bound, _bound, _bound);
                    else
                        graphics.DrawImage(SpriteHandler.MineExploded, _x * _bound, _y * _bound, _bound, _bound);
                }
                else
                {
                    if(_mineCount != 0 && !_isExploded)
                        graphics.DrawImage(SpriteHandler.GetCount(_mineCount), _x * _bound, _y * _bound, _bound, _bound);
                }
            }
            if (_isFlagged && !_isExploded)
                graphics.DrawImage(SpriteHandler.Flag, _x * _bound, _y * _bound, _bound, _bound);
            if (_isHovered)
                graphics.DrawImage(SpriteHandler.Highlight, _x * _bound, _y * _bound, _bound, _bound);
        }
        //Debugging
        public override string ToString()
        {
            return $"{_x}:{_y}";
        }
    }
}
