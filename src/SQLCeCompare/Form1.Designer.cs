namespace SQLCe
{
    partial class Form1
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonDumpSchema = new System.Windows.Forms.Button();
            this.checkBoxDispInfo = new System.Windows.Forms.CheckBox();
            this.checkBoxDumpToFile = new System.Windows.Forms.CheckBox();
            this.buttonSwapFiles = new System.Windows.Forms.Button();
            this.checkBoxOnlyDif = new System.Windows.Forms.CheckBox();
            this.buttonDumpData = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonOpen1 = new System.Windows.Forms.Button();
            this.textBoxSQLCePath1 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonOpen2 = new System.Windows.Forms.Button();
            this.textBoxSQLCePath2 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxDetail1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDetail2 = new System.Windows.Forms.RichTextBox();
            this.checkBoxSync = new System.Windows.Forms.CheckBox();
            this.panelTop.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.checkBoxSync);
            this.panelTop.Controls.Add(this.buttonDumpSchema);
            this.panelTop.Controls.Add(this.checkBoxDispInfo);
            this.panelTop.Controls.Add(this.checkBoxDumpToFile);
            this.panelTop.Controls.Add(this.buttonSwapFiles);
            this.panelTop.Controls.Add(this.checkBoxOnlyDif);
            this.panelTop.Controls.Add(this.buttonDumpData);
            this.panelTop.Controls.Add(this.buttonCompare);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1576, 48);
            this.panelTop.TabIndex = 0;
            // 
            // buttonDumpSchema
            // 
            this.buttonDumpSchema.Location = new System.Drawing.Point(417, 5);
            this.buttonDumpSchema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDumpSchema.Name = "buttonDumpSchema";
            this.buttonDumpSchema.Size = new System.Drawing.Size(167, 40);
            this.buttonDumpSchema.TabIndex = 7;
            this.buttonDumpSchema.Text = "DumpSchema";
            this.buttonDumpSchema.UseVisualStyleBackColor = true;
            this.buttonDumpSchema.Click += new System.EventHandler(this.buttonDumpSchema_Click);
            // 
            // checkBoxDispInfo
            // 
            this.checkBoxDispInfo.AutoSize = true;
            this.checkBoxDispInfo.Location = new System.Drawing.Point(1060, 10);
            this.checkBoxDispInfo.Name = "checkBoxDispInfo";
            this.checkBoxDispInfo.Size = new System.Drawing.Size(122, 29);
            this.checkBoxDispInfo.TabIndex = 6;
            this.checkBoxDispInfo.Text = "DispInfo";
            this.checkBoxDispInfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxDumpToFile
            // 
            this.checkBoxDumpToFile.AutoSize = true;
            this.checkBoxDumpToFile.Location = new System.Drawing.Point(684, 10);
            this.checkBoxDumpToFile.Name = "checkBoxDumpToFile";
            this.checkBoxDumpToFile.Size = new System.Drawing.Size(160, 29);
            this.checkBoxDumpToFile.TabIndex = 5;
            this.checkBoxDumpToFile.Text = "DumpToFile";
            this.checkBoxDumpToFile.UseVisualStyleBackColor = true;
            // 
            // buttonSwapFiles
            // 
            this.buttonSwapFiles.Location = new System.Drawing.Point(1233, 5);
            this.buttonSwapFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSwapFiles.Name = "buttonSwapFiles";
            this.buttonSwapFiles.Size = new System.Drawing.Size(187, 40);
            this.buttonSwapFiles.TabIndex = 4;
            this.buttonSwapFiles.Text = "<- SwapFiles ->";
            this.buttonSwapFiles.UseVisualStyleBackColor = true;
            this.buttonSwapFiles.Click += new System.EventHandler(this.buttonSwapFiles_Click);
            // 
            // checkBoxOnlyDif
            // 
            this.checkBoxOnlyDif.AutoSize = true;
            this.checkBoxOnlyDif.Location = new System.Drawing.Point(870, 10);
            this.checkBoxOnlyDif.Name = "checkBoxOnlyDif";
            this.checkBoxOnlyDif.Size = new System.Drawing.Size(174, 29);
            this.checkBoxOnlyDif.TabIndex = 3;
            this.checkBoxOnlyDif.Text = "nur ungleiche";
            this.checkBoxOnlyDif.UseVisualStyleBackColor = true;
            // 
            // buttonDumpData
            // 
            this.buttonDumpData.Location = new System.Drawing.Point(264, 5);
            this.buttonDumpData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDumpData.Name = "buttonDumpData";
            this.buttonDumpData.Size = new System.Drawing.Size(145, 40);
            this.buttonDumpData.TabIndex = 2;
            this.buttonDumpData.Text = "DumpData";
            this.buttonDumpData.UseVisualStyleBackColor = true;
            this.buttonDumpData.Click += new System.EventHandler(this.buttonDumpData_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(126, 5);
            this.buttonCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(129, 40);
            this.buttonCompare.TabIndex = 1;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(4, 5);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 849);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1576, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Location = new System.Drawing.Point(133, 46);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.listBox2);
            this.splitContainerMain.Panel2.Controls.Add(this.panelRight);
            this.splitContainerMain.Size = new System.Drawing.Size(1100, 431);
            this.splitContainerMain.SplitterDistance = 550;
            this.splitContainerMain.SplitterWidth = 6;
            this.splitContainerMain.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(28, 89);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 304);
            this.listBox1.TabIndex = 1;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonOpen1);
            this.panelLeft.Controls.Add(this.textBoxSQLCePath1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(550, 70);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonOpen1
            // 
            this.buttonOpen1.Location = new System.Drawing.Point(3, 34);
            this.buttonOpen1.Name = "buttonOpen1";
            this.buttonOpen1.Size = new System.Drawing.Size(129, 36);
            this.buttonOpen1.TabIndex = 2;
            this.buttonOpen1.Text = "Open...";
            this.buttonOpen1.UseVisualStyleBackColor = true;
            this.buttonOpen1.Click += new System.EventHandler(this.buttonOpen1_Click);
            // 
            // textBoxSQLCePath1
            // 
            this.textBoxSQLCePath1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSQLCePath1.Location = new System.Drawing.Point(0, 0);
            this.textBoxSQLCePath1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSQLCePath1.Name = "textBoxSQLCePath1";
            this.textBoxSQLCePath1.Size = new System.Drawing.Size(550, 31);
            this.textBoxSQLCePath1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(39, 89);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(386, 304);
            this.listBox2.TabIndex = 1;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.buttonOpen2);
            this.panelRight.Controls.Add(this.textBoxSQLCePath2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(544, 70);
            this.panelRight.TabIndex = 0;
            // 
            // buttonOpen2
            // 
            this.buttonOpen2.Location = new System.Drawing.Point(3, 34);
            this.buttonOpen2.Name = "buttonOpen2";
            this.buttonOpen2.Size = new System.Drawing.Size(129, 36);
            this.buttonOpen2.TabIndex = 3;
            this.buttonOpen2.Text = "Open...";
            this.buttonOpen2.UseVisualStyleBackColor = true;
            this.buttonOpen2.Click += new System.EventHandler(this.buttonOpen2_Click);
            // 
            // textBoxSQLCePath2
            // 
            this.textBoxSQLCePath2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSQLCePath2.Location = new System.Drawing.Point(0, 0);
            this.textBoxSQLCePath2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSQLCePath2.Name = "textBoxSQLCePath2";
            this.textBoxSQLCePath2.Size = new System.Drawing.Size(544, 31);
            this.textBoxSQLCePath2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 73);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1322, 759);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(37, 29);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxDetail1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBoxDetail2);
            this.splitContainer2.Size = new System.Drawing.Size(1231, 200);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBoxDetail1
            // 
            this.richTextBoxDetail1.Location = new System.Drawing.Point(26, 21);
            this.richTextBoxDetail1.Name = "richTextBoxDetail1";
            this.richTextBoxDetail1.Size = new System.Drawing.Size(811, 62);
            this.richTextBoxDetail1.TabIndex = 1;
            this.richTextBoxDetail1.Text = "";
            // 
            // richTextBoxDetail2
            // 
            this.richTextBoxDetail2.Location = new System.Drawing.Point(26, 18);
            this.richTextBoxDetail2.Name = "richTextBoxDetail2";
            this.richTextBoxDetail2.Size = new System.Drawing.Size(811, 62);
            this.richTextBoxDetail2.TabIndex = 2;
            this.richTextBoxDetail2.Text = "";
            // 
            // checkBoxSync
            // 
            this.checkBoxSync.AutoSize = true;
            this.checkBoxSync.Location = new System.Drawing.Point(1427, 10);
            this.checkBoxSync.Name = "checkBoxSync";
            this.checkBoxSync.Size = new System.Drawing.Size(92, 29);
            this.checkBoxSync.TabIndex = 8;
            this.checkBoxSync.Text = "Sync";
            this.checkBoxSync.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 886);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SQLCe-Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox textBoxSQLCePath1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox textBoxSQLCePath2;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonDumpData;
        private System.Windows.Forms.CheckBox checkBoxOnlyDif;
        private System.Windows.Forms.Button buttonOpen1;
        private System.Windows.Forms.Button buttonOpen2;
        private System.Windows.Forms.Button buttonSwapFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxDetail1;
        private System.Windows.Forms.RichTextBox richTextBoxDetail2;
        private System.Windows.Forms.CheckBox checkBoxDumpToFile;
        private System.Windows.Forms.CheckBox checkBoxDispInfo;
        private System.Windows.Forms.Button buttonDumpSchema;
        private System.Windows.Forms.CheckBox checkBoxSync;
    }
}

