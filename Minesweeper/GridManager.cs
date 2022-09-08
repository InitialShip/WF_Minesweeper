using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
    /*
     * GridManager dùng để quản lý các ô trên màng hình game
     * Độ khó:
     * EASY 12 x 6 : 10 MINES
     * MEDIUM 20 x 10 : 35 MINES
     * HARD 26 x 13 : 75 MINES
     */
    class GridManager
    {
        private Dictionary<Coordinate, Cell> cells;
        private int _width;
        private int _height;
        private int _cellBound;
        private int _mineNum;
        private int _flagRemain;
        public int FlagRemain { get { return _flagRemain; } }
        private static Random rand = new Random();
        public GridManager(int width, int height,int mineNum,int cellBound)
        {
            _width = width;
            _height = height;
            _cellBound = cellBound;
            _mineNum = mineNum;
            _flagRemain = mineNum;
            GenerateGrid();
        }
        // Khởi tạo các cell 
        private void GenerateGrid()
        {
            cells = new Dictionary<Coordinate, Cell>();

            for (int i = 0; i < _width; i++)
                for (int j = 0; j < _height; j++)
                {
                    Cell newCell = new Cell(i,j, _cellBound);
                    bool isOffSet = (i % 2 == 0 && j % 2!=0)||(i%2 != 0 && j % 2 == 0);
                    newCell.Init(isOffSet);
                    cells[new Coordinate(i, j)] = newCell;
                }
            InitMines(_mineNum);
        }
        /* Khởi tạo một số lượng mìn vào các cell ngẫu nhiên
         * Cách thực hiện:
         * 1. Lấy danh sách các cell từ Dictionary
         * 2. Xáo trộn danh sách đã lấy ra với giá trị ngẫu nhiên
         * 3. Lấy ra số lượng các cell đầu tiên bằng với số mìn cần thêm và gán giá trị _isMine là true
         * Do danh sách lấy ra đã được sắp xếp một cách ngẫu nhiên, dẫn đến việc lấy ra N đối tượng đầu tiên là ngẫu nhiên
         */
        private void InitMines(int mineNum)
        {
            var cellList = cells.Values.Select(c => c).ToList();
            var shuffledList = cellList.OrderBy(c => rand.Next()).ToList();
            foreach(Cell cell in shuffledList.Take(mineNum))
            {
                cell.InitMine();
            }
        }
        /*
         * Phương thức vẽ các cell lên màng hình
         * Nhận vào rawX và rawY là vị trí hiện tại của chuột, để thực hiện hightlight
         */
        public void Render(Graphics graphics,int rawX, int rawY)
        {
            for(int i = 0; i < cells.Count; i++)
            {
                cells.ElementAt(i).Value.Render(graphics);
                cells.ElementAt(i).Value.IsHovering(PositionToCoordinate(rawX, rawY));
            }
        }
        /*
         * Phương thức map vị trí thật về vị trí hạng và cột
         */
        private Coordinate PositionToCoordinate(int rawX, int rawY)
        {
            return new Coordinate((int)rawX / _cellBound, (int)rawY / _cellBound);
        }
        /*
         * Phương thức lấy cell từ Dictionary từ vị trí của chuột
         */
        public Cell GetCellAtMousePosition(int rawX, int rawY)
        {
            if (cells.TryGetValue(PositionToCoordinate(rawX, rawY), out Cell cell))
                return cell;
            return null;
        }
        /*
         * Phương thức đặt cờ lên một cell
         */
        public void PlaceFlag(int rawX, int rawY)
        {
            Cell cell = GetCellAtMousePosition(rawX, rawY);
            if (cell == null)
                return;
            if (cell.IsClick)
                return;
            if (cell.IsFlagged)
            {
                _flagRemain += 1;
                cell.ToggleFlag();
            }
            else
            {
                if(_flagRemain > 0)
                {
                    _flagRemain -= 1;
                    cell.ToggleFlag();
                }
            }
        }
        /*
         * Phương thức xử lý click chuột lên một cell
         */
        public void Click(int rawX, int rawY)
        {
            Cell cell = GetCellAtMousePosition(rawX, rawY);
            if (cell == null)
                return;
            if (cell.IsFlagged)
                return;
            CheckCell(cell);
        }
        /*
         * Phương thức thực hiện kiểm tra một cell và các cell lân cận bằng thuật toán "vết dầu loan"
         * Cách thực hiện:
         * Đối với cell không phải là mìn
         * 1. Thực hiện đếm số mìn tồn tại lân cận 
         * 2. Nếu lân cận không có mìn thì thực hiện lại bước 1 cho các cell lân cận, 
         * cho đến khi không còn cell nào không có mìn lân cận
         * Đối với các cell là mìn cách thực hiện khá tương tự
         */
        private void CheckCell(Cell cell)
        {
            if (cell.IsClick)
                return;
            if (cell.IsFlagged)
                return;
            if (!cell.Click()) // not mine
            {
                List<Cell> neighbour = GetNeighbour(cell);
                int mineCount = neighbour.Where(c => c.IsMine == true).Count();
                cell.InitMineCount(mineCount);
                if(mineCount == 0)
                {
                    foreach (Cell nCell in neighbour)
                        CheckCell(nCell);
                }
            }
            else // is mine
            {
                Explode(cell, 50);
            }
        }
        /*
         * cell là mìn bị click phải sẽ có tỉ lệ là 100% nổ
         * int chance là phần trăm 0 <= chance <= 100
         * chance là tỉ lệ nổ cho các cell là mìn bị ảnh hưởng
         * chance sẽ được giảm một nữa sau mỗi mức đệ quy, tránh quá nhiều mìn phát nổ cùng một lúc
         * Cách thực hiện:
         * 1. Lấy danh sách các cell lân cận
         * 2. Chọn ra những cell là mìn trong danh sách lấy được, và thực hiện đệ quy đối với các cell này
         * Thuật toán dừng khi không còn mìn nào bị phát nổ
         */
        private void Explode(Cell cell, int chance)
        {
            List<Cell> neighbour = GetNeighbour(cell);
            //Lấy ra các cell là mìn và chưa nổ
            foreach(Cell bCell in neighbour.Where(c => c.IsMine && !c.IsExploded))
            {
                if (rand.Next(0, 100) <= chance)
                    Explode(bCell, chance / 2);
            }
            //Set các cell lân cận thành các ô bị nổ, để render lên màn hình
            foreach (Cell nCell in neighbour)
            {
                //Thêm con số vào để thực hiện animation
                if(nCell.MineCount != 0)
                    ParticleHandler.AddParticle(new Particle(nCell.GetActualX(), nCell.GetActualY(), nCell.Bound, nCell.MineCount));
                nCell.Blasted();
            }
        }
        /*
         * Phương thức lấy danh sách các cell lân cận tại một cell bất kì
         */
        private List<Cell> GetNeighbour(Cell cell)
        {
            List<Cell> neighbour = new List<Cell>();
            var key = cells.FirstOrDefault(c => c.Value == cell).Key;
            for(int xOff = -1; xOff <= 1; xOff++)
            {
                int x = key.X + xOff;
                for(int yOff = -1; yOff <= 1; yOff++)
                {
                    if (xOff == 0 && yOff == 0)
                        continue;
                    int y = key.Y + yOff;
                    cells.TryGetValue(new Coordinate(x,y), out Cell nC);
                    if(nC != null)
                        neighbour.Add(nC);
                }
            }
            return neighbour;
        }
        /*
         * Một game kết thúc khi 
         * Các ô không phải là mìn đã được click hết
         * Hoặc các ô là mìn đã bị click hết
         */
        public bool IsOver()
        {
            if(GetRemainingTile() == 0)
                return true;
            if (GetRemainingMine() == 0)
                return true;
            return false;
        }
        public int GetRemainingMine()
        {
            return cells.Values.Select(c =>c).Where(c => !c.IsExploded && c.IsMine).Count();
        }
        public int GetRemainingTile()
        {
            return cells.Values.Select(c => c).Where(c => c.IsClick == false && c.IsMine == false).Count();
        }
        public void ShowMines()
        {
            var mines = cells.Values.Select(c => c).Where(c => c.IsMine && !c.IsExploded);
            foreach(Cell cell in mines)
            {
                cell.Show();
            }
        }
        
    }
}
