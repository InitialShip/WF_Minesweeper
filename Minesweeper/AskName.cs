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
    public partial class AskName : Form
    {
        private Record _record;
        public AskName()
        {
            InitializeComponent();
        }
        public void SetData(Record record)
        {
            _record = record;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveName();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DefaultName();
        }
        private void SaveName()
        {
            string name = txt_Name.Text;
            if (String.IsNullOrWhiteSpace(name))
                _record.Name = "NO NAME";
            else
                _record.Name = name;
        }
        private void DefaultName()
        {
            _record.Name = "NO NAME";
        }
    }
}
