using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPDevelop
{
    public partial class BodyPartGUI : Form
    {
        public BodyPartGUI()
        {
            InitializeComponent();
            FillBodyPartGUI();
        }

        private void FillBodyPartGUI()
        {
            dataGridView1.Rows.Add("3", "Torso");
            dataGridView1.Rows.Add("4", "Groin");
            dataGridView1.Rows.Add("5", "Left arm");
            dataGridView1.Rows.Add("6", "Right arm");
            dataGridView1.Rows.Add("7", "Left leg");
            dataGridView1.Rows.Add("8", "Right leg");
            dataGridView1.Rows.Add("9", "Head");
        }
    }
}
