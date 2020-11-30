namespace DeleteUnusedFolders
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
            this.deleteBT = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.scanBT = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathTtextBox = new System.Windows.Forms.TextBox();
            this.searchBT = new System.Windows.Forms.Button();
            this.selectAllBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateType = new System.Windows.Forms.ComboBox();
            this.dateTypeDetail = new System.Windows.Forms.ComboBox();
            this.unSelectAllBT = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBT
            // 
            this.deleteBT.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.Location = new System.Drawing.Point(417, 397);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(101, 41);
            this.deleteBT.TabIndex = 1;
            this.deleteBT.Text = "Delete";
            this.deleteBT.UseVisualStyleBackColor = false;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 126);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(506, 256);
            this.checkedListBox1.TabIndex = 2;
            // 
            // scanBT
            // 
            this.scanBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanBT.Location = new System.Drawing.Point(36, 397);
            this.scanBT.Name = "scanBT";
            this.scanBT.Size = new System.Drawing.Size(101, 41);
            this.scanBT.TabIndex = 3;
            this.scanBT.Text = "Scan";
            this.scanBT.UseVisualStyleBackColor = true;
            this.scanBT.Click += new System.EventHandler(this.scanBT_Click);
            // 
            // pathTtextBox
            // 
            this.pathTtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTtextBox.Location = new System.Drawing.Point(66, 50);
            this.pathTtextBox.Multiline = true;
            this.pathTtextBox.Name = "pathTtextBox";
            this.pathTtextBox.Size = new System.Drawing.Size(359, 30);
            this.pathTtextBox.TabIndex = 4;
            // 
            // searchBT
            // 
            this.searchBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBT.Location = new System.Drawing.Point(431, 50);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(87, 33);
            this.searchBT.TabIndex = 5;
            this.searchBT.Text = "Search";
            this.searchBT.UseVisualStyleBackColor = true;
            this.searchBT.Click += new System.EventHandler(this.searchBT_Click);
            // 
            // selectAllBT
            // 
            this.selectAllBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllBT.Location = new System.Drawing.Point(163, 397);
            this.selectAllBT.Name = "selectAllBT";
            this.selectAllBT.Size = new System.Drawing.Size(101, 41);
            this.selectAllBT.TabIndex = 6;
            this.selectAllBT.Text = "Select all";
            this.selectAllBT.UseVisualStyleBackColor = true;
            this.selectAllBT.Click += new System.EventHandler(this.selectAllBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Path :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not used For :";
            // 
            // dateType
            // 
            this.dateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateType.FormattingEnabled = true;
            this.dateType.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Day"});
            this.dateType.Location = new System.Drawing.Point(225, 93);
            this.dateType.Name = "dateType";
            this.dateType.Size = new System.Drawing.Size(72, 28);
            this.dateType.TabIndex = 10;
            this.dateType.Text = "Year";
            this.dateType.SelectedIndexChanged += new System.EventHandler(this.dateType_SelectedIndexChanged);
            // 
            // dateTypeDetail
            // 
            this.dateTypeDetail.DropDownHeight = 100;
            this.dateTypeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTypeDetail.FormattingEnabled = true;
            this.dateTypeDetail.IntegralHeight = false;
            this.dateTypeDetail.Location = new System.Drawing.Point(125, 93);
            this.dateTypeDetail.Name = "dateTypeDetail";
            this.dateTypeDetail.Size = new System.Drawing.Size(84, 28);
            this.dateTypeDetail.TabIndex = 11;
            // 
            // unSelectAllBT
            // 
            this.unSelectAllBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unSelectAllBT.Location = new System.Drawing.Point(290, 397);
            this.unSelectAllBT.Name = "unSelectAllBT";
            this.unSelectAllBT.Size = new System.Drawing.Size(101, 41);
            this.unSelectAllBT.TabIndex = 12;
            this.unSelectAllBT.Text = "Unselect all";
            this.unSelectAllBT.UseVisualStyleBackColor = true;
            this.unSelectAllBT.Click += new System.EventHandler(this.unSelectAllBT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.unSelectAllBT);
            this.Controls.Add(this.dateTypeDetail);
            this.Controls.Add(this.dateType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectAllBT);
            this.Controls.Add(this.searchBT);
            this.Controls.Add(this.pathTtextBox);
            this.Controls.Add(this.scanBT);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button scanBT;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox pathTtextBox;
        private System.Windows.Forms.Button searchBT;
        private System.Windows.Forms.Button selectAllBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dateType;
        private System.Windows.Forms.ComboBox dateTypeDetail;
        private System.Windows.Forms.Button unSelectAllBT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

