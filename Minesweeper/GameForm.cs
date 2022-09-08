using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Minesweeper
{
    public partial class GameForm : Form
    {
        /*
        * EASY 12 x 6 : 10
        * MEDIUM 20 x 10 : 35
        * HARD 26 x 13 : 75
        */
        private bool _isOver;
        private static System.Timers.Timer timer;
        private static int time;
        public GameForm()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics graphics;
        GridManager gridManager;

        TimeSpan _lastFrameTime = TimeSpan.Zero;
        Stopwatch _frameTimer = Stopwatch.StartNew();

        protected float deltaTime;
        //deltaTime là khoảng thời gian mà máy render 1 frame
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            TimeSpan currentFrameTime = _frameTimer.Elapsed;
            deltaTime = (float)(currentFrameTime - _lastFrameTime).TotalSeconds;
            Run(deltaTime);
            _lastFrameTime = currentFrameTime;
            canvas.Invalidate();
        }
        // It's getting messy
        private void Run(float deltaTime)
        {
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Black);
            this.lb_Time.Text = time.ToString().PadLeft(3, '0');
            this.lb_NFlag.Text = gridManager.FlagRemain.ToString();
            this.lb_MineRemain.Text = gridManager.GetRemainingMine().ToString();
            gridManager.Render(graphics, currentX, currentY);
            if (_isOver || time >= 1000)
            {
                _isOver = false;
                gridManager.ShowMines(); // Show mines after game over
                gridManager.Render(graphics, currentX, currentY);
                graphics.Dispose();
                canvas.Image = bitmap;
                GameEnd();
            }
            ParticleHandler.UpdateParticles(deltaTime); // add time scale
            ParticleHandler.Render(graphics);
            graphics.Dispose();
            canvas.Image = bitmap;
        }
        private void GameEnd()
        {
            this.canvas.Paint -= Canvas_Paint;
            GameResult gameResult = new GameResult();
            gameResult.SetData((Level)comb_Level.SelectedItem,time, gridManager.GetRemainingMine());
            DialogResult dialogResult = gameResult.ShowDialog(this);
            switch (dialogResult)
            {
                case DialogResult.OK:
                    if (comb_Level.SelectedIndex < 2)
                        comb_Level.SelectedIndex++;
                    InitGame();
                    return;
                default:
                    InitGame();
                    return;
            }
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            List<Level> levels = new List<Level> { 
                new Level(1,"Easy   | 12x6  10 MINES"),
                new Level(2,"Medium | 20x10 35 MINES"),
                new Level(3,"Hard   | 26x13 75 MINES")};
            comb_Level.DataSource = levels;
            comb_Level.DisplayMember = "Name";
            comb_Level.ValueMember = "ID";
            ParticleHandler.SetBound(canvas.Height);
            timer = new System.Timers.Timer(1000);
            InitGame();
            this.comb_Level.SelectedIndexChanged += new EventHandler(this.comb_Level_SelectedIndexChanged);
        }

        private static void HandleTimer(object sender, EventArgs e)
        {
            time++;
        }

        private int currentX;
        private int currentY;
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            currentX = e.X;
            currentY = e.Y;
        }
        private void canvas_MouseLeave(object sender, EventArgs e)
        {
            currentX = -100;
            currentY = -100;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!timer.Enabled)
                timer.Start();
            if (_isOver)
                return;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    gridManager.Click(e.X, e.Y);
                    if (gridManager.IsOver())// is over
                    {
                        timer.Stop();
                        timer.Elapsed -= HandleTimer;
                        _isOver = true;
                    }
                    return;
                case MouseButtons.Right:
                    gridManager.PlaceFlag(e.X, e.Y);
                    return;
            }
        }
        private void InitGame()
        {
            _isOver = false;
            time = 0;
            if (timer.Enabled)
            {
                timer.Elapsed -= HandleTimer;
                timer.Stop();
            }
            timer.Elapsed += HandleTimer;
            
            currentX = -100;
            currentY = -100;
            bitmap = new Bitmap(canvas.Width, canvas.Height);
            switch (comb_Level.SelectedValue)
            {
                case 1:
                    MakeEasy();
                    break;
                case 2:
                    MakeMedium();
                    break;
                case 3:
                    MakeHard();
                    break;
            }
            ParticleHandler.Clear();
            this.canvas.Paint += new PaintEventHandler(this.Canvas_Paint);
            this.Run(0);
        }
        public void MakeEasy()
        {
            gridManager = new GridManager(12, 6, 10, canvas.Width / 12);
        }
        public void MakeMedium()
        {
            gridManager = new GridManager(20, 10, 35, canvas.Width / 20);
        }
        public void MakeHard()
        {
            gridManager = new GridManager(26, 13, 75, canvas.Width / 26);
        }

        private void comb_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_Level.SelectedItem == null)
                return;
            InitGame();
        }
    }
    public class Level
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public Level(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
