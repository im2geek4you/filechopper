namespace FileSplitter
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxHeaderPatern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxTail = new System.Windows.Forms.CheckBox();
            this.checkBoxHeader = new System.Windows.Forms.CheckBox();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeHeaderPaternOnOut = new System.Windows.Forms.CheckBox();
            this.groupBoxTail = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeTailPaternOnOut = new System.Windows.Forms.CheckBox();
            this.textBoxTailPatern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPatern = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFileExtension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarProcess = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutputFileName = new System.Windows.Forms.TextBox();
            this.buttonProcessSplit = new System.Windows.Forms.Button();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.labelStatus = new System.Windows.Forms.Label();
            this.backgroundWorkerFileSplitter = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInputFilename = new System.Windows.Forms.TextBox();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            this.groupBoxTail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHeaderPatern
            // 
            this.textBoxHeaderPatern.Location = new System.Drawing.Point(90, 22);
            this.textBoxHeaderPatern.Name = "textBoxHeaderPatern";
            this.textBoxHeaderPatern.Size = new System.Drawing.Size(336, 20);
            this.textBoxHeaderPatern.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Pattern";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(633, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTail);
            this.groupBox1.Controls.Add(this.checkBoxHeader);
            this.groupBox1.Controls.Add(this.groupBoxHeader);
            this.groupBox1.Controls.Add(this.groupBoxTail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxPatern);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spllit section";
            // 
            // checkBoxTail
            // 
            this.checkBoxTail.AutoSize = true;
            this.checkBoxTail.Checked = true;
            this.checkBoxTail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTail.Location = new System.Drawing.Point(376, 30);
            this.checkBoxTail.Name = "checkBoxTail";
            this.checkBoxTail.Size = new System.Drawing.Size(43, 17);
            this.checkBoxTail.TabIndex = 11;
            this.checkBoxTail.Text = "Tail";
            this.checkBoxTail.UseVisualStyleBackColor = true;
            this.checkBoxTail.CheckedChanged += new System.EventHandler(this.checkBoxTail_CheckedChanged);
            // 
            // checkBoxHeader
            // 
            this.checkBoxHeader.AutoSize = true;
            this.checkBoxHeader.Checked = true;
            this.checkBoxHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHeader.Location = new System.Drawing.Point(309, 30);
            this.checkBoxHeader.Name = "checkBoxHeader";
            this.checkBoxHeader.Size = new System.Drawing.Size(61, 17);
            this.checkBoxHeader.TabIndex = 10;
            this.checkBoxHeader.Text = "Header";
            this.checkBoxHeader.UseVisualStyleBackColor = true;
            this.checkBoxHeader.CheckedChanged += new System.EventHandler(this.checkBoxHeader_CheckedChanged);
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.Controls.Add(this.checkBoxIncludeHeaderPaternOnOut);
            this.groupBoxHeader.Controls.Add(this.textBoxHeaderPatern);
            this.groupBoxHeader.Controls.Add(this.label1);
            this.groupBoxHeader.Location = new System.Drawing.Point(15, 67);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(572, 62);
            this.groupBoxHeader.TabIndex = 9;
            this.groupBoxHeader.TabStop = false;
            this.groupBoxHeader.Text = "Header";
            // 
            // checkBoxIncludeHeaderPaternOnOut
            // 
            this.checkBoxIncludeHeaderPaternOnOut.AutoSize = true;
            this.checkBoxIncludeHeaderPaternOnOut.Checked = true;
            this.checkBoxIncludeHeaderPaternOnOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeHeaderPaternOnOut.Location = new System.Drawing.Point(436, 25);
            this.checkBoxIncludeHeaderPaternOnOut.Name = "checkBoxIncludeHeaderPaternOnOut";
            this.checkBoxIncludeHeaderPaternOnOut.Size = new System.Drawing.Size(121, 17);
            this.checkBoxIncludeHeaderPaternOnOut.TabIndex = 2;
            this.checkBoxIncludeHeaderPaternOnOut.Text = "Include in output file";
            this.checkBoxIncludeHeaderPaternOnOut.UseVisualStyleBackColor = true;
            // 
            // groupBoxTail
            // 
            this.groupBoxTail.Controls.Add(this.checkBoxIncludeTailPaternOnOut);
            this.groupBoxTail.Controls.Add(this.textBoxTailPatern);
            this.groupBoxTail.Controls.Add(this.label4);
            this.groupBoxTail.Location = new System.Drawing.Point(17, 135);
            this.groupBoxTail.Name = "groupBoxTail";
            this.groupBoxTail.Size = new System.Drawing.Size(570, 64);
            this.groupBoxTail.TabIndex = 8;
            this.groupBoxTail.TabStop = false;
            this.groupBoxTail.Text = "Tail";
            // 
            // checkBoxIncludeTailPaternOnOut
            // 
            this.checkBoxIncludeTailPaternOnOut.AutoSize = true;
            this.checkBoxIncludeTailPaternOnOut.Checked = true;
            this.checkBoxIncludeTailPaternOnOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeTailPaternOnOut.Location = new System.Drawing.Point(434, 28);
            this.checkBoxIncludeTailPaternOnOut.Name = "checkBoxIncludeTailPaternOnOut";
            this.checkBoxIncludeTailPaternOnOut.Size = new System.Drawing.Size(121, 17);
            this.checkBoxIncludeTailPaternOnOut.TabIndex = 7;
            this.checkBoxIncludeTailPaternOnOut.Text = "Include in output file";
            this.checkBoxIncludeTailPaternOnOut.UseVisualStyleBackColor = true;
            // 
            // textBoxTailPatern
            // 
            this.textBoxTailPatern.Location = new System.Drawing.Point(88, 25);
            this.textBoxTailPatern.Name = "textBoxTailPatern";
            this.textBoxTailPatern.Size = new System.Drawing.Size(336, 20);
            this.textBoxTailPatern.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patern Type";
            // 
            // comboBoxPatern
            // 
            this.comboBoxPatern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatern.FormattingEnabled = true;
            this.comboBoxPatern.Items.AddRange(new object[] {
            "HEXADECIMAL",
            "DECIMAL"});
            this.comboBoxPatern.Location = new System.Drawing.Point(105, 28);
            this.comboBoxPatern.Name = "comboBoxPatern";
            this.comboBoxPatern.Size = new System.Drawing.Size(156, 21);
            this.comboBoxPatern.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFileExtension);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelProgress);
            this.groupBox2.Controls.Add(this.progressBarProcess);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxOutputFileName);
            this.groupBox2.Location = new System.Drawing.Point(12, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output section";
            // 
            // textBoxFileExtension
            // 
            this.textBoxFileExtension.Location = new System.Drawing.Point(413, 36);
            this.textBoxFileExtension.Name = "textBoxFileExtension";
            this.textBoxFileExtension.Size = new System.Drawing.Size(133, 20);
            this.textBoxFileExtension.TabIndex = 10;
            this.textBoxFileExtension.Text = ".bin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "File Extension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Progress";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(553, 86);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(21, 13);
            this.labelProgress.TabIndex = 7;
            this.labelProgress.Text = "0%";
            // 
            // progressBarProcess
            // 
            this.progressBarProcess.Location = new System.Drawing.Point(105, 81);
            this.progressBarProcess.Name = "progressBarProcess";
            this.progressBarProcess.Size = new System.Drawing.Size(441, 23);
            this.progressBarProcess.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output filename";
            // 
            // textBoxOutputFileName
            // 
            this.textBoxOutputFileName.Location = new System.Drawing.Point(105, 36);
            this.textBoxOutputFileName.Name = "textBoxOutputFileName";
            this.textBoxOutputFileName.Size = new System.Drawing.Size(208, 20);
            this.textBoxOutputFileName.TabIndex = 0;
            this.textBoxOutputFileName.Text = "splittedfile{x}";
            // 
            // buttonProcessSplit
            // 
            this.buttonProcessSplit.Location = new System.Drawing.Point(545, 450);
            this.buttonProcessSplit.Name = "buttonProcessSplit";
            this.buttonProcessSplit.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessSplit.TabIndex = 5;
            this.buttonProcessSplit.Text = "Process";
            this.buttonProcessSplit.UseVisualStyleBackColor = true;
            this.buttonProcessSplit.Click += new System.EventHandler(this.buttonProcessSplit_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 460);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            // 
            // backgroundWorkerFileSplitter
            // 
            this.backgroundWorkerFileSplitter.WorkerReportsProgress = true;
            this.backgroundWorkerFileSplitter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFileSplitter_DoWork);
            this.backgroundWorkerFileSplitter.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerFileSplitter_ProgressChanged);
            this.backgroundWorkerFileSplitter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerFileSplitter_RunWorkerCompleted);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInputFilename);
            this.groupBoxInput.Controls.Add(this.labelInputFile);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 27);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(608, 81);
            this.groupBoxInput.TabIndex = 7;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input Section";
            // 
            // textBoxInputFilename
            // 
            this.textBoxInputFilename.Location = new System.Drawing.Point(105, 30);
            this.textBoxInputFilename.Name = "textBoxInputFilename";
            this.textBoxInputFilename.Size = new System.Drawing.Size(469, 20);
            this.textBoxInputFilename.TabIndex = 1;
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(18, 33);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(73, 13);
            this.labelInputFile.TabIndex = 0;
            this.labelInputFile.Text = "Input filename";
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(463, 450);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 23);
            this.buttonScan.TabIndex = 8;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 482);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonProcessSplit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "File Chopper";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            this.groupBoxTail.ResumeLayout(false);
            this.groupBoxTail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeaderPatern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPatern;
        private System.Windows.Forms.CheckBox checkBoxIncludeHeaderPaternOnOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutputFileName;
        private System.Windows.Forms.Button buttonProcessSplit;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxTail;
        private System.Windows.Forms.CheckBox checkBoxHeader;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.GroupBox groupBoxTail;
        private System.Windows.Forms.CheckBox checkBoxIncludeTailPaternOnOut;
        private System.Windows.Forms.TextBox textBoxTailPatern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBarProcess;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerFileSplitter;
        private System.Windows.Forms.TextBox textBoxFileExtension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInputFilename;
        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.Button buttonScan;
    }
}

