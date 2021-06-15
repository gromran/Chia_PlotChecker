
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
            this.clBFolders = new System.Windows.Forms.CheckedListBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnScanForPlots = new System.Windows.Forms.Button();
            this.btnCheckPlots = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clBFolders
            // 
            this.clBFolders.FormattingEnabled = true;
            this.clBFolders.Location = new System.Drawing.Point(12, 70);
            this.clBFolders.Name = "clBFolders";
            this.clBFolders.Size = new System.Drawing.Size(212, 400);
            this.clBFolders.TabIndex = 0;
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
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(230, 70);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(830, 618);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
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
            this.btnCheckPlots.Location = new System.Drawing.Point(972, 12);
            this.btnCheckPlots.Name = "btnCheckPlots";
            this.btnCheckPlots.Size = new System.Drawing.Size(88, 52);
            this.btnCheckPlots.TabIndex = 6;
            this.btnCheckPlots.Text = "check Plots";
            this.btnCheckPlots.UseVisualStyleBackColor = true;
            this.btnCheckPlots.Click += new System.EventHandler(this.BtnCheckPlots_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 700);
            this.Controls.Add(this.btnCheckPlots);
            this.Controls.Add(this.btnScanForPlots);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.clBFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clBFolders;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnScanForPlots;
        private System.Windows.Forms.Button btnCheckPlots;
    }
}

