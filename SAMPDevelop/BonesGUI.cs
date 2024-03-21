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
    public partial class BonesGUI : Form
    {
        public BonesGUI()
        {
            InitializeComponent();
            FillBonesGUI();
        }

        private void FillBonesGUI()
        {
            dataGridView1.Rows.Add("1", "Spine");
            dataGridView1.Rows.Add("2", "Head");
            dataGridView1.Rows.Add("3", "Left upper arm");
            dataGridView1.Rows.Add("4", "Right upper arm");
            dataGridView1.Rows.Add("5", "Left hand");
            dataGridView1.Rows.Add("6", "Right hand");
            dataGridView1.Rows.Add("7", "Left thigh");
            dataGridView1.Rows.Add("8", "Right thigh");
            dataGridView1.Rows.Add("9", "Left foot");
            dataGridView1.Rows.Add("10", "Right foot");
            dataGridView1.Rows.Add("11", "Right calf");
            dataGridView1.Rows.Add("12", "Left calf");
            dataGridView1.Rows.Add("13", "Left forearm");
            dataGridView1.Rows.Add("14", "Right forearm");
            dataGridView1.Rows.Add("15", "Left clavicle (shoulder)");
            dataGridView1.Rows.Add("16", "Right clavicle (shoulder)");
            dataGridView1.Rows.Add("17", "Neck");
            dataGridView1.Rows.Add("18", "Jaw");
        }
    }
}
