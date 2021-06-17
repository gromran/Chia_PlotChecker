
namespace PlotChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "asdad"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuHighlight, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "sadasd"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ActiveCaption, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("sadasd");
            this.clBFolders = new System.Windows.Forms.CheckedListBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView_Plots = new System.Windows.Forms.ListView();
            this.btnScanForPlots = new System.Windows.Forms.Button();
            this.btnCheckPlots = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.chFolder = new System.Windows.Forms.ColumnHeader();
            this.chFreeSize = new System.Windows.Forms.ColumnHeader();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown_nValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nValue)).BeginInit();
            this.SuspendLayout();
            // 
            // clBFolders
            // 
            this.clBFolders.FormattingEnabled = true;
            this.clBFolders.Location = new System.Drawing.Point(12, 70);
            this.clBFolders.Name = "clBFolders";
            this.clBFolders.Size = new System.Drawing.Size(212, 400);
            this.clBFolders.TabIndex = 0;
            this.clBFolders.SelectedIndexChanged += new System.EventHandler(this.ClBFolders_SelectedIndexChanged);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(12, 12);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "add folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "remove selected folders";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "clear list";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listView_Plots
            // 
            this.listView_Plots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Plots.FullRowSelect = true;
            this.listView_Plots.GridLines = true;
            this.listView_Plots.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Plots.HideSelection = false;
            this.listView_Plots.Location = new System.Drawing.Point(230, 70);
            this.listView_Plots.Name = "listView_Plots";
            this.listView_Plots.ShowItemToolTips = true;
            this.listView_Plots.Size = new System.Drawing.Size(830, 618);
            this.listView_Plots.TabIndex = 4;
            this.listView_Plots.UseCompatibleStateImageBehavior = false;
            this.listView_Plots.View = System.Windows.Forms.View.Details;
            // 
            // btnScanForPlots
            // 
            this.btnScanForPlots.Location = new System.Drawing.Point(167, 12);
            this.btnScanForPlots.Name = "btnScanForPlots";
            this.btnScanForPlots.Size = new System.Drawing.Size(57, 52);
            this.btnScanForPlots.TabIndex = 5;
            this.btnScanForPlots.Text = "scan for plots";
            this.btnScanForPlots.UseVisualStyleBackColor = true;
            this.btnScanForPlots.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnScanForPlots_MouseClick);
            // 
            // btnCheckPlots
            // 
            this.btnCheckPlots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckPlots.Location = new System.Drawing.Point(972, 12);
            this.btnCheckPlots.Name = "btnCheckPlots";
            this.btnCheckPlots.Size = new System.Drawing.Size(88, 52);
            this.btnCheckPlots.TabIndex = 6;
            this.btnCheckPlots.Text = "check Plots";
            this.btnCheckPlots.UseVisualStyleBackColor = true;
            this.btnCheckPlots.Click += new System.EventHandler(this.BtnCheckPlots_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFolder,
            this.chFreeSize});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView2.Location = new System.Drawing.Point(12, 476);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(212, 212);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // chFolder
            // 
            this.chFolder.Text = "Folder";
            // 
            // chFreeSize
            // 
            this.chFreeSize.Text = "Free Size";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(230, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(736, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // numericUpDown_nValue
            // 
            this.numericUpDown_nValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_nValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown_nValue.Location = new System.Drawing.Point(907, 12);
            this.numericUpDown_nValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_nValue.Name = "numericUpDown_nValue";
            this.numericUpDown_nValue.Size = new System.Drawing.Size(59, 25);
            this.numericUpDown_nValue.TabIndex = 9;
            this.numericUpDown_nValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_nValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "filter (-g):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 23);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 700);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_nValue);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnCheckPlots);
            this.Controls.Add(this.btnScanForPlots);
            this.Controls.Add(this.listView_Plots);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.clBFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clBFolders;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView_Plots;
        private System.Windows.Forms.Button btnScanForPlots;
        private System.Windows.Forms.Button btnCheckPlots;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader chFolder;
        private System.Windows.Forms.ColumnHeader chFreeSize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown_nValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

