using System.Windows.Forms;

namespace SAMPDevelop
{
    partial class WeaponsGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponsGUI));
            dataGridView1 = new DataGridView();
            Slot = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            gName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ModelID = new DataGridViewTextBoxColumn();
            Clip = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Slot, Type, Image, gName, ID, ModelID, Clip });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(776, 426);
            dataGridView1.TabIndex = 0;
            // 
            // Slot
            // 
            Slot.HeaderText = "Slot";
            Slot.Name = "Slot";
            Slot.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 150;
            // 
            // Image
            // 
            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.ReadOnly = true;
            // 
            // gName
            // 
            gName.HeaderText = "Name";
            gName.Name = "gName";
            gName.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // ModelID
            // 
            ModelID.HeaderText = "ModelID";
            ModelID.Name = "ModelID";
            ModelID.ReadOnly = true;
            // 
            // Clip
            // 
            Clip.HeaderText = "Clip";
            Clip.Name = "Clip";
            Clip.ReadOnly = true;
            Clip.Width = 65;
            // 
            // WeaponsGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WeaponsGUI";
            Text = "Weapons ID";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Slot;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn gName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ModelID;
        private DataGridViewTextBoxColumn Clip;
    }
}