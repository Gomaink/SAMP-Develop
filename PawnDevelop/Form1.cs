using System.Windows.Forms;
using WindowsFormsApp;

namespace PawnDevelop
{
    public partial class Form1 : Form
    {
        private string filePath = "";

        public Form1()
        {
            InitializeComponent();
            richTextBox1.BorderStyle = BorderStyle.None;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            richTextBox1.Size = new System.Drawing.Size(this.ClientSize.Width - 50, this.ClientSize.Height - 50);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) //new file
            {
                FileOperations.CreateNewFile(richTextBox1, filePath);
            }

            if (e.Control && e.KeyCode == Keys.O) //open file
            {
                if (FileOperations.OpenFile(richTextBox1, out string newFilePath))
                {
                    filePath = newFilePath;
                }
            }

            if (e.Control && e.KeyCode == Keys.S) //save file
            {
                if (!string.IsNullOrEmpty(filePath))
                    FileOperations.SaveFile(richTextBox1, filePath);
                else
                    FileOperations.SaveFileAs(richTextBox1, ref filePath);
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.F) //find
            {
                FileOperations.Find(richTextBox1);
            }

            if (e.Control && e.KeyCode == Keys.H) //replace
            {
                FileOperations.Replace(richTextBox1);
            }

            if (e.Control && e.KeyCode == Keys.G) //go to
            {
                FileOperations.GoTo(richTextBox1);
            }

            if (e.KeyCode == Keys.F5) //compile file
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    string extension = Path.GetExtension(filePath);
                    if (extension.Equals(".pwn", StringComparison.OrdinalIgnoreCase))
                    {
                        FileOperations.CompilePawnFile(richTextBox1, filePath);
                    }
                    else
                    {
                        MessageBox.Show("The file is not a .pwn file or has not yet been saved.", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The file path is empty.", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.CreateNewFile(richTextBox1, filePath);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileOperations.OpenFile(richTextBox1, out string newFilePath))
            {
                filePath = newFilePath;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
                FileOperations.SaveFile(richTextBox1, filePath);
            else
                FileOperations.SaveFileAs(richTextBox1, ref filePath);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.SaveFileAs(richTextBox1, ref filePath);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.Exit(richTextBox1, filePath);
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = string.Empty;
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.Find(richTextBox1);
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.Replace(richTextBox1);
        }

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.GoTo(richTextBox1);
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void CompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string extension = Path.GetExtension(filePath);
                if (extension.Equals(".pwn", StringComparison.OrdinalIgnoreCase))
                {
                    FileOperations.CompilePawnFile(richTextBox1, filePath);
                }
                else
                {
                    MessageBox.Show("The file is not a .pwn file or has not yet been saved.", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The file path is empty.", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color lightBackColor = Color.White;
            Color lightForeColor = Color.Black;

            // Define as cores do menuStrip
            menuStrip1.BackColor = lightBackColor;
            menuStrip1.ForeColor = lightForeColor;

            // Define as cores dos itens do menu
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = lightBackColor;
                item.ForeColor = lightForeColor;

                // Define as cores dos itens do submenu
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    subItem.BackColor = lightBackColor;
                    subItem.ForeColor = lightForeColor;
                }
            }

            lightToolStripMenuItem.BackColor = lightBackColor;
            lightToolStripMenuItem.ForeColor = lightForeColor;
            darkToolStripMenuItem.BackColor = lightBackColor;
            darkToolStripMenuItem.ForeColor = lightForeColor;

            // Define as cores da richTextBox
            richTextBox1.BackColor = lightBackColor;
            richTextBox1.ForeColor = lightForeColor;

            // Define o esquema de cores do formulário
            BackColor = lightBackColor;
            ForeColor = lightForeColor;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkBackColor = Color.FromArgb(35, 35, 35);
            Color darkForeColor = Color.White;

            // Define as cores do menuStrip
            menuStrip1.BackColor = darkBackColor;
            menuStrip1.ForeColor = darkForeColor;

            // Define as cores dos itens do menu
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = darkBackColor;
                item.ForeColor = darkForeColor;

                // Define as cores dos itens do submenu
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                {
                    subItem.BackColor = darkBackColor;
                    subItem.ForeColor = darkForeColor;
                }
            }

            lightToolStripMenuItem.BackColor = darkBackColor;
            lightToolStripMenuItem.ForeColor = darkForeColor;
            darkToolStripMenuItem.BackColor = darkBackColor;
            darkToolStripMenuItem.ForeColor = darkForeColor;

            // Define as cores da richTextBox
            richTextBox1.BackColor = darkBackColor;
            richTextBox1.ForeColor = darkForeColor;

            // Define o esquema de cores do formulário
            BackColor = darkBackColor;
            ForeColor = darkForeColor;
        }
    }
}
