namespace Abg160130Asg4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderLineNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelTextSearch = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.labelLineMatched = new System.Windows.Forms.Label();
            this.textBoxLineMatched = new System.Windows.Forms.TextBox();
            this.timeFormat = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLineNo,
            this.columnHeaderText});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(867, 351);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderLineNo
            // 
            this.columnHeaderLineNo.Text = "Line No";
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Text = "Text";
            this.columnHeaderText.Width = 800;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(12, 381);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(64, 15);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "File Name";
            // 
            // labelTextSearch
            // 
            this.labelTextSearch.AutoSize = true;
            this.labelTextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSearch.Location = new System.Drawing.Point(12, 414);
            this.labelTextSearch.Name = "labelTextSearch";
            this.labelTextSearch.Size = new System.Drawing.Size(72, 15);
            this.labelTextSearch.TabIndex = 2;
            this.labelTextSearch.Text = "Text Search";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(109, 380);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(646, 20);
            this.textBoxFileName.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(109, 413);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(646, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(793, 378);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFile.TabIndex = 5;
            this.buttonBrowseFile.Text = "Browse File";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(793, 411);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(910, 253);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(68, 15);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Total Time ";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(913, 281);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(62, 20);
            this.textBoxTime.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "Select File";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // labelLineMatched
            // 
            this.labelLineMatched.AutoSize = true;
            this.labelLineMatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineMatched.Location = new System.Drawing.Point(885, 132);
            this.labelLineMatched.Name = "labelLineMatched";
            this.labelLineMatched.Size = new System.Drawing.Size(119, 15);
            this.labelLineMatched.TabIndex = 10;
            this.labelLineMatched.Text = "No. of lines matched";
            // 
            // textBoxLineMatched
            // 
            this.textBoxLineMatched.Location = new System.Drawing.Point(913, 161);
            this.textBoxLineMatched.Name = "textBoxLineMatched";
            this.textBoxLineMatched.Size = new System.Drawing.Size(62, 20);
            this.textBoxLineMatched.TabIndex = 11;
            // 
            // timeFormat
            // 
            this.timeFormat.AutoSize = true;
            this.timeFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFormat.Location = new System.Drawing.Point(910, 304);
            this.timeFormat.Name = "timeFormat";
            this.timeFormat.Size = new System.Drawing.Size(73, 15);
            this.timeFormat.TabIndex = 12;
            this.timeFormat.Text = " hh:mm:ss.ff";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel2.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 474);
            this.Controls.Add(this.timeFormat);
            this.Controls.Add(this.textBoxLineMatched);
            this.Controls.Add(this.labelLineMatched);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelTextSearch);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "SearchText";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderLineNo;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelTextSearch;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label labelLineMatched;
        private System.Windows.Forms.TextBox textBoxLineMatched;
        private System.Windows.Forms.Label timeFormat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

