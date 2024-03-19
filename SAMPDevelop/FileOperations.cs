using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace WindowsFormsApp
{
    public class FileOperations
    {
        public static bool IsFastColoredTextBoxEmpty(FastColoredTextBox fastColoredTextBox)
        {
            return string.IsNullOrEmpty(fastColoredTextBox.Text);
        }

        public static void CreateNewFile(FastColoredTextBox fastColoredTextBox, string filePath)
        {
            if (!IsFastColoredTextBoxEmpty(fastColoredTextBox))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before creating a new file?", "Save changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PWN files (*.pwn)|*.pwn|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox.Text);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            fastColoredTextBox.Clear();
        }

        public static bool OpenFile(FastColoredTextBox fastColoredTextBox, out string newFilePath)
        {
            newFilePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PWN files (*.pwn)|*.pwn|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = System.IO.File.ReadAllText(openFileDialog.FileName);
                    fastColoredTextBox.Text = content;
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

        public static bool OpenFolder(FastColoredTextBox fastColoredTextBox, out string newFolderPath)
        {
            newFolderPath = string.Empty;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    fastColoredTextBox.Clear();
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    newFolderPath = selectedPath;

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }


        public static void SaveFile(FastColoredTextBox fastColoredTextBox, string filePath)
        {
            try
            {
                File.WriteAllText(filePath, fastColoredTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveFileAs(FastColoredTextBox fastColoredTextBox, ref string filePath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PWN files (*.pwn)|*.pwn|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox.Text);
                    filePath = saveFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Exit(FastColoredTextBox fastColoredTextBox, string filePath)
        {
            if (!string.IsNullOrEmpty(fastColoredTextBox.Text) && fastColoredTextBox.Text != fastColoredTextBox.Tag?.ToString() && fastColoredTextBox.Text != File.ReadAllText(filePath))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before exiting?", "Save changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        SaveFile(fastColoredTextBox, filePath);
                    }
                    else
                    {
                        SaveFileAs(fastColoredTextBox, ref filePath);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            Application.Exit();
        }

        public static void CompilePawnFile(FastColoredTextBox fastColoredTextBox, string filePath)
        {
            try
            {
                string pwnDirectory = Path.GetDirectoryName(filePath);
                string parentDirectory = Directory.GetParent(pwnDirectory).FullName;
                string compilerPath = Path.Combine($"{parentDirectory}\\pawno\\pawncc.exe");

                SaveFile(fastColoredTextBox, filePath);
                if (!File.Exists(compilerPath))
                {
                    MessageBox.Show("Compiler pawncc.exe not found in file directory.\r\n", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"{output}", "Compiled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{error}", "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error compiling the file: " + ex.Message, "Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
