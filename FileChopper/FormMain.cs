using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplitter
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();
            comboBoxPatern.SelectedIndex = 0;
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogMain.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBoxInputFilename.Text = openFileDialogMain.FileName;
            }
        }

        private List<int> IndexOfSequence(byte[] buffer, byte[] pattern, int startIndex)
        {
            List<int> positions = new List<int>();
            int i = Array.IndexOf<byte>(buffer, pattern[0], startIndex);
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                byte[] segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);
                if (segment.SequenceEqual<byte>(pattern))
                    positions.Add(i);
                //i = Array.IndexOf<byte>(buffer, pattern[0], i + pattern.Length);
                i = Array.IndexOf<byte>(buffer, pattern[0], i + 1);
            }
            return positions;
        }

        private void checkBoxHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHeader.Checked)
            {
                groupBoxHeader.Enabled = true;
            }
            else
            {
                groupBoxHeader.Enabled = false;
            }
        }

        private void checkBoxTail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTail.Checked)
            {
                groupBoxTail.Enabled = true;
            }
            else
            {
                groupBoxTail.Enabled = false;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File splitter 0.0.0.1\nIm2geek4you");
        }

        private void buttonProcessSplit_Click(object sender, EventArgs e)
        {
            //create settings object to pass to the background worker
            SplitSettings settings = new SplitSettings();

            DialogResult result = folderBrowserDialogOutput.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                settings.OutputFolder = folderBrowserDialogOutput.SelectedPath;

                switch (comboBoxPatern.SelectedItem.ToString())
                {
                    case "HEXADECIMAL":
                        settings.StartPatern = HexStringToByteArray(textBoxHeaderPatern.Text.Replace(" ", "").Replace(",", ""));
                        settings.EndPatern = HexStringToByteArray(textBoxTailPatern.Text.Replace(" ", "").Replace(",", ""));
                        break;

                    case "DECIMAL":
                        settings.StartPatern = DecStringToByteArray(textBoxHeaderPatern.Text);
                        settings.EndPatern = DecStringToByteArray(textBoxTailPatern.Text);
                        break;

                    default:
                        MessageBox.Show("unknown patern");
                        break;
                }


                settings.IncludeHeaderPatern = checkBoxIncludeHeaderPaternOnOut.Checked;
                settings.IncludeTailPatern = checkBoxIncludeTailPaternOnOut.Checked;

                settings.FileExtension = textBoxFileExtension.Text;
                settings.OutputFileNamePatern = textBoxOutputFileName.Text;

                if (textBoxInputFilename.Text != string.Empty || textBoxOutputFileName.Text != string.Empty)
                {
                    settings.FileName = textBoxInputFilename.Text;
                    settings.Scan = false;

                    processFile(settings);
                }
                else
                {
                    MessageBox.Show("Invalid Input! Please set valid file names.");
                }

            }        

        }

        private void processFile(SplitSettings settings)
        {
            if (backgroundWorkerFileSplitter.IsBusy != true)
            {
                labelStatus.Text = "Processing...";
                labelProgress.Text = ("0%");
                progressBarProcess.Value = 0;
                // Start the asynchronous operation.
                backgroundWorkerFileSplitter.RunWorkerAsync(settings);
            }
        }

        private void backgroundWorkerFileSplitter_DoWork(object sender, DoWorkEventArgs e)
        {

            SplitSettings settings = (SplitSettings) e.Argument;

            byte[] fileBytes = File.ReadAllBytes(settings.FileName);

            byte[] startpattern = settings.StartPatern;
            byte[] endpattern = settings.EndPatern;

            byte[] slice;

            List<int> startpositions = null;
            List<int> endpositions = null;

            if (settings.StartPatern != null)
            {
                if (settings.StartPatern.Length > 0)
                {
                    startpositions = IndexOfSequence(fileBytes, startpattern, 0);
                    if (settings.Scan)
                    {
                        MessageBox.Show("Found " + startpositions.Count.ToString() + " header paterns!");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert a start patern or disable it if not needed!");
                }

            }
            
            if (settings.EndPatern != null)
            {
                if (settings.EndPatern.Length > 0)
                {
                    endpositions = IndexOfSequence(fileBytes, endpattern, 0);
                    if (settings.Scan)
                    {
                        MessageBox.Show("Found " + endpositions.Count.ToString() + " tail paterns!");
                    }
                }
                else
                {
                    MessageBox.Show("Please insert an end patern or disable it if not needed!");
                }

            }
            


            if (!settings.Scan)
            {

                //only header selected
                for (int i = 0; i < startpositions.Count; i++)
                {
                    if (i == startpositions.Count - 1)
                    {
                        slice = new byte[fileBytes.Count() - startpositions[i]];
                        Array.Copy(fileBytes, startpositions[i], slice, 0, fileBytes.Count() - startpositions[i]);
                        File.WriteAllBytes(settings.OutputFolder + "\\" + settings.OutputFileNamePatern.Replace("{x}", i.ToString()) + settings.FileExtension, slice);
                    }
                    else
                    {
                        slice = new byte[startpositions[i + 1] - startpositions[i]];
                        Array.Copy(fileBytes, startpositions[i], slice, 0, startpositions[i + 1] - startpositions[i]);
                        File.WriteAllBytes(settings.OutputFolder + "\\" + settings.OutputFileNamePatern.Replace("{x}", i.ToString()) + settings.FileExtension, slice);
                    }
                    backgroundWorkerFileSplitter.ReportProgress((int)((double)i / startpositions.Count * 100));
                }
                //only tail selected

                //header and tail

            }
            e.Result = settings;
        }


        public static byte[] HexStringToByteArray(string hex)
        {
            byte[] values=null;

            try
            {
                values = Enumerable.Range(0, hex.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                 .ToArray();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to convert patern!\n" + ex.Message);
            }

            return values;
        }

        public static byte[] DecStringToByteArray(string dec)
        {
            string[] values = dec.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return values.Select(byte.Parse).ToArray();
        }

        private void backgroundWorkerFileSplitter_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgress.Text = (e.ProgressPercentage.ToString() + "%");
            progressBarProcess.Value = e.ProgressPercentage;

        }

        private void backgroundWorkerFileSplitter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                labelStatus.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                labelStatus.Text = "Error: " + e.Error.Message;
            }
            else
            {
                SplitSettings settings = (SplitSettings) e.Result;
                if (settings.Scan) {
                    labelStatus.Text = "Scan done!";
                    labelProgress.Text = ("0%");
                    progressBarProcess.Value = 0;
                }
                else
                {
                    labelStatus.Text = "Process done!";
                    labelProgress.Text = ("100%");
                    progressBarProcess.Value = 100;
                }

            }
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            //create settings object to pass to the background worker
            SplitSettings settings = new SplitSettings();

            if (textBoxInputFilename.Text == string.Empty)
            {
                MessageBox.Show("Please a select file for chopping!");
                return;
            }

            if (!checkBoxHeader.Checked && !checkBoxTail.Checked)
            {
                MessageBox.Show("Please set Header or Tail (or both) values!");
                return;
            }

                settings.OutputFolder = "";

            switch (comboBoxPatern.SelectedItem.ToString())
            {
                case "HEXADECIMAL":
                    if (checkBoxHeader.Checked) settings.StartPatern = HexStringToByteArray(textBoxHeaderPatern.Text.Replace(" ", "").Replace(",", ""));
                    if (checkBoxTail.Checked) settings.EndPatern = HexStringToByteArray(textBoxTailPatern.Text.Replace(" ", "").Replace(",", ""));
                    break;

                case "DECIMAL":
                    if (checkBoxHeader.Checked) settings.StartPatern = DecStringToByteArray(textBoxHeaderPatern.Text);
                    if (checkBoxTail.Checked) settings.EndPatern = DecStringToByteArray(textBoxTailPatern.Text);
                    break;

                default:
                    MessageBox.Show("Unknown patern!");
                    break;
            }


            settings.IncludeHeaderPatern = checkBoxIncludeHeaderPaternOnOut.Checked;
            settings.IncludeTailPatern = checkBoxIncludeTailPaternOnOut.Checked;

            settings.FileExtension = textBoxFileExtension.Text;
            settings.OutputFileNamePatern = textBoxOutputFileName.Text;

            if (textBoxInputFilename.Text != string.Empty || textBoxOutputFileName.Text != string.Empty)
            {
                settings.FileName = textBoxInputFilename.Text;
                settings.Scan = true;

                processFile(settings);
            }
            else
            {
                MessageBox.Show("Invalid Input! Please set valid file names.");
            }


        }
    }
}
