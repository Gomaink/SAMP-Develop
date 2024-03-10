using System.Windows.Forms;
using WindowsFormsApp;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using System;

namespace PawnDevelop
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private FastColoredTextBox fastColoredTextBox1;

        public Form1()
        {
            InitializeComponent();
            InitializeFastColoredTextBox();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {

            fastColoredTextBox1.Size = new System.Drawing.Size(this.ClientSize.Width - 50, this.ClientSize.Height - 50);
        }

        private void InitializeFastColoredTextBox()
        {
            fastColoredTextBox1 = new FastColoredTextBox();
            fastColoredTextBox1.BorderStyle = BorderStyle.None;
            fastColoredTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            fastColoredTextBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fastColoredTextBox1.ForeColor = Color.White;
            fastColoredTextBox1.Location = new Point(12, 39);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Size = new Size(776, 399);
            fastColoredTextBox1.TabIndex = 1;
            fastColoredTextBox1.LineNumberColor = Color.White;
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(30, 30, 30);
            fastColoredTextBox1.TextChanged += fastColoredTextBox1_TextChanged;
 
            Controls.Add(fastColoredTextBox1);
        }

        Style keywordStyle = new TextStyle(new SolidBrush(Color.FromArgb(189, 147, 249)), null, FontStyle.Regular);
        Style typeStyle = new TextStyle(new SolidBrush(Color.FromArgb(139, 233, 253)), null, FontStyle.Regular);
        Style literalStyle = new TextStyle(new SolidBrush(Color.FromArgb(255, 121, 198)), null, FontStyle.Regular);
        Style commentStyle = new TextStyle(new SolidBrush(Color.FromArgb(80, 250, 123)), null, FontStyle.Regular);
        Style stringStyle = new TextStyle(new SolidBrush(Color.FromArgb(255, 85, 85)), null, FontStyle.Regular);
        Style macroStyle = new TextStyle(new SolidBrush(Color.FromArgb(255, 184, 108)), null, FontStyle.Regular);

        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            FastColoredTextBoxNS.FastColoredTextBox textBox = sender as FastColoredTextBoxNS.FastColoredTextBox;
            if (textBox == null) return;

            e.ChangedRange.ClearStyle(StyleIndex.All);

            e.ChangedRange.SetStyle(keywordStyle, @"\b(new|main|public|auto|break|case|char|const|continue|default|do|double|else|enum|extern|float|for|goto|if|inline|int|long|register|restrict|return|short|signed|sizeof|static|struct|switch|typedef|union|unsigned|void|volatile|while)\b(?![^\/]*\/\*(?:(?!\*\/)[\s\S])*?[^\/]*\*\/)");

            e.ChangedRange.SetStyle(typeStyle, @"\b(bool|_Bool|char|short|int|long|float|double|signed|unsigned|void|_Complex|_Imaginary)\b");

            e.ChangedRange.SetStyle(macroStyle, @"#(define|include|pragma|endif)\b");

            e.ChangedRange.SetStyle(literalStyle, @"\b(true|false|null)\b");

            FastColoredTextBoxNS.Range range = textBox.VisibleRange;
            if (range == null)
                range = textBox.Range;

            range.SetStyle(commentStyle, @"//.*$", RegexOptions.Multiline);
            range.SetStyle(commentStyle, @"/\*.*?\*/", RegexOptions.Singleline);
            range.SetStyle(commentStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            range.SetStyle(commentStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);

            e.ChangedRange.SetStyle(stringStyle, "\"(?:\\\\\"|[^\"])*\"");

            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("{", "}");
            e.ChangedRange.SetFoldingMarkers(@"/\*", @"\*/");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) //new file
            {
                FileOperations.CreateNewFile(fastColoredTextBox1, filePath);
            }

            if (e.Control && e.KeyCode == Keys.O) //open file
            {
                if (FileOperations.OpenFile(fastColoredTextBox1, out string newFilePath))
                {
                    filePath = newFilePath;
                }
            }

            if (e.Control && e.KeyCode == Keys.S) //save file
            {
                if (!string.IsNullOrEmpty(filePath))
                    FileOperations.SaveFile(fastColoredTextBox1, filePath);
                else
                    FileOperations.SaveFileAs(fastColoredTextBox1, ref filePath);
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.F5) //compile file
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    string extension = Path.GetExtension(filePath);
                    if (extension.Equals(".pwn", StringComparison.OrdinalIgnoreCase))
                    {
                        FileOperations.CompilePawnFile(fastColoredTextBox1, filePath);
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
            FileOperations.CreateNewFile(fastColoredTextBox1, filePath);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileOperations.OpenFile(fastColoredTextBox1, out string newFilePath))
            {
                filePath = newFilePath;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
                FileOperations.SaveFile(fastColoredTextBox1, filePath);
            else
                FileOperations.SaveFileAs(fastColoredTextBox1, ref filePath);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.SaveFileAs(fastColoredTextBox1, ref filePath);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileOperations.Exit(fastColoredTextBox1, filePath);
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectedText = string.Empty;
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void CompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string extension = Path.GetExtension(filePath);
                if (extension.Equals(".pwn", StringComparison.OrdinalIgnoreCase))
                {
                    FileOperations.CompilePawnFile(fastColoredTextBox1, filePath);
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

            menuStrip1.BackColor = lightBackColor;
            menuStrip1.ForeColor = lightForeColor;

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = lightBackColor;
                item.ForeColor = lightForeColor;

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

            fastColoredTextBox1.BackColor = lightBackColor;
            fastColoredTextBox1.ForeColor = lightForeColor;

            fastColoredTextBox1.LineNumberColor = Color.Black;
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(255, 255, 255);

            BackColor = lightBackColor;
            ForeColor = lightForeColor;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkBackColor = Color.FromArgb(35, 35, 35);
            Color darkForeColor = Color.White;

            menuStrip1.BackColor = darkBackColor;
            menuStrip1.ForeColor = darkForeColor;

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = darkBackColor;
                item.ForeColor = darkForeColor;

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

            fastColoredTextBox1.BackColor = darkBackColor;
            fastColoredTextBox1.ForeColor = darkForeColor;

            fastColoredTextBox1.LineNumberColor = Color.White;
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(30, 30, 30);

            BackColor = darkBackColor;
            ForeColor = darkForeColor;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
