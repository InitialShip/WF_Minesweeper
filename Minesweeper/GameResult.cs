using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameResult : Form
    {
        private Level _level;
        private int _time;
        private int _mineRemain;
        private Record record;
        public GameResult()
        {
            InitializeComponent();
        }
        public void SetData(Level level,int time, int mineRemain)
        {
            _level = level;
            _time = time;
            _mineRemain = mineRemain;
            if(_time <= 1000 && _mineRemain > 0) // Nếu còn thời gian và mìn chưa nổ hết
            {
                record = new Record("No Name", mineRemain, time);
                HandleSaveReSult();
            }
            ShowData();
        }
        private void ShowData()
        {
            this.lb_Level.Text = _level.Name;
            this.lb_Time.Text = _time.ToString().PadLeft(3, '0');
            this.lb_Mine.Text = _mineRemain.ToString().PadLeft(2, '0');
            if (_time >= 1000)
                this.lb_Result.Text = "Time Over!";
            else
                if (_mineRemain <= 0)
                this.lb_Result.Text = "All Mines Exploded!";
            else
                this.lb_Result.Text = "Level Completed!";
        }
        private void HandleSaveReSult()
        {
            ScoreData scoreData = FileHandler.Load<ScoreData>("score/score.xml");
            if (scoreData == null)
                scoreData = new ScoreData();
            switch (_level.ID)
            {
                case 1:
                    scoreData.AddRecordToEasy(record);
                    break;
                case 2:
                    scoreData.AddRecordToMedium(record);
                    break;
                case 3:
                    scoreData.AddRecordToHard(record);
                    break;
            }
            int rank = scoreData.GetRank(_level.ID,record);
            this.lb_Top.Text = rank.ToString();
            if(rank <= 10)
            {
                AskName askName = new AskName();
                askName.SetData(record);
                askName.ShowDialog();
            }
            FileHandler.Save(scoreData, "score");

        }
    }
}
