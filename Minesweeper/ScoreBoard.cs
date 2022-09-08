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
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }
        private ScoreData scoreData;
        private void ScoreBoard_Load(object sender, EventArgs e)
        {

            scoreData = FileHandler.Load<ScoreData>("score/score.xml");
            if (scoreData == null)
                scoreData = new ScoreData();
            grid_Easy.DataSource = scoreData.Easy.GetRecords();
            grid_Medium.DataSource = scoreData.Medium.GetRecords();
            grid_Hard.DataSource = scoreData.Hard.GetRecords();

            grid_Easy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_Easy.Columns[1].HeaderText = "Mine Remaining";
            grid_Easy.Columns[2].HeaderText = "Time";
            grid_Medium.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_Medium.Columns[1].HeaderText = "Mine Remaining";
            grid_Medium.Columns[2].HeaderText = "Time (s)";
            grid_Hard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_Hard.Columns[1].HeaderText = "Mine Remaining";
            grid_Hard.Columns[2].HeaderText = "Time";
        }
    }
}
