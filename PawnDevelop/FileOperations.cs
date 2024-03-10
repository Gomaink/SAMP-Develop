using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class FileOperations
    {
        public static bool IsRichTextBoxEmpty(RichTextBox richTextBox)
        {
            return string.IsNullOrEmpty(richTextBox.Text);
        }

        public static void CreateNewFile(RichTextBox richTextBox, string filePath)
        {
            if (!IsRichTextBoxEmpty(richTextBox))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before creating a new file?", "Save changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PWN files (*.pwn)|*.pwn|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            richTextBox.Clear();
        }
        public static bool OpenFile(RichTextBox richTextBox, out string newFilePath)
        {
            newFilePath = string.Empty; 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PWN files (*.pwn)|*.pwn|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = System.IO.File.ReadAllText(openFileDialog.FileName);
                    richTextBox.Text = content;
                    newFilePath = openFileDialog.FileName; 
                    return true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }
            return false; 
        }

        public static void SaveFile(RichTextBox richTextBox, string filePath)
        {
            try
            {
                File.WriteAllText(filePath, richTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveFileAs(RichTextBox richTextBox, ref string filePath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PWN files (*.pwn)|*.pwn|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox.Text);
                    filePath = saveFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void Exit(RichTextBox richTextBox, string filePath)
        {
            if (!string.IsNullOrEmpty(richTextBox.Text) && richTextBox.Modified)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before exiting?", "Save changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        SaveFile(richTextBox, filePath);
                    }
                    else
                    {
                        SaveFileAs(richTextBox, ref filePath);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            Application.Exit();
        }
        public static void Find(RichTextBox richTextBox)
        {
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("Enter the text to be found:", "Find", "");
            if (!string.IsNullOrEmpty(searchText))
            {
                int index = richTextBox.Text.IndexOf(searchText);
                if (index >= 0)
                {
                    richTextBox.Select(index, searchText.Length);
                    richTextBox.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show("Text not found.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void Replace(RichTextBox richTextBox)
        {
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("Enter the text to be replaced:", "Replace", "");
            string replaceText = Microsoft.VisualBasic.Interaction.InputBox("Enter replacement text:", "Replace", "");
            if (!string.IsNullOrEmpty(searchText))
            {
                richTextBox.Text = richTextBox.Text.Replace(searchText, replaceText);
            }
        }

        public static void GoTo(RichTextBox richTextBox)
        {
            int lineToGo;
            if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter the line number to go:", "Go to line"), out lineToGo))
            {
                int index = richTextBox.GetFirstCharIndexFromLine(lineToGo - 1);
                if (index >= 0)
                {
                    richTextBox.Select(index, 0);
                    richTextBox.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show("Invalid line number.", "Go to line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void CompilePawnFile(RichTextBox richTextBox, string filePath)
        {
            try
            {
                string pwnDirectory = Path.GetDirectoryName(filePath);
                string parentDirectory = Directory.GetParent(pwnDirectory).FullName;
                string compilerPath = Path.Combine($"{parentDirectory}\\pawno\\pawncc.exe");

                SaveFile(richTextBox, filePath);
                if (!File.Exists(compilerPath))
                {
                    MessageBox.Show("Compiler pawncc.exe not found in file directory.\r\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = compilerPath,
                    Arguments = $"{filePath} -D{pwnDirectory} -;+ -(+ -d3",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = parentDirectory
                };

                Process process = new Process { StartInfo = psi };
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show($"{output}", "Compilated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{error}", "Compilation failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error compiling the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}