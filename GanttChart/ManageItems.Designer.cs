namespace Scheduler
{
    partial class ManageItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItems));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.atText = new System.Windows.Forms.NumericUpDown();
            this.prText = new System.Windows.Forms.NumericUpDown();
            this.tText = new System.Windows.Forms.NumericUpDown();
            this.DoneButton = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tText)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listView1_PreviewKeyDown);
            this.splitContainer1.Size = new System.Drawing.Size(597, 320);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.atText);
            this.splitContainer2.Panel1.Controls.Add(this.prText);
            this.splitContainer2.Panel1.Controls.Add(this.tText);
            this.splitContainer2.Panel1.Controls.Add(this.DoneButton);
            this.splitContainer2.Panel1.Controls.Add(this.idText);
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button8);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.button7);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button6);
            this.splitContainer2.Panel2.Controls.Add(this.button5);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.listView2);
            this.splitContainer2.Size = new System.Drawing.Size(597, 270);
            this.splitContainer2.SplitterDistance = 472;
            this.splitContainer2.TabIndex = 0;
            // 
            // atText
            // 
            this.atText.Location = new System.Drawing.Point(76, 29);
            this.atText.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.atText.Name = "atText";
            this.atText.Size = new System.Drawing.Size(60, 20);
            this.atText.TabIndex = 11;
            this.atText.Visible = false;
            this.atText.Enter += new System.EventHandler(this.idText_Enter);
            this.atText.Leave += new System.EventHandler(this.idText_Leave);
            // 
            // prText
            // 
            this.prText.Location = new System.Drawing.Point(254, 26);
            this.prText.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prText.Name = "prText";
            this.prText.Size = new System.Drawing.Size(60, 20);
            this.prText.TabIndex = 13;
            this.prText.Visible = false;
            this.prText.Enter += new System.EventHandler(this.idText_Enter);
            this.prText.Leave += new System.EventHandler(this.idText_Leave);
            // 
            // tText
            // 
            this.tText.Location = new System.Drawing.Point(169, 29);
            this.tText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tText.Name = "tText";
            this.tText.Size = new System.Drawing.Size(59, 20);
            this.tText.TabIndex = 12;
            this.tText.Visible = false;
            this.tText.Enter += new System.EventHandler(this.idText_Enter);
            this.tText.Leave += new System.EventHandler(this.idText_Leave);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(199, 115);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(0, 0);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Visible = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(8, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(46, 20);
            this.idText.TabIndex = 3;
            this.idText.Text = "1000";
            this.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idText.Visible = false;
            this.idText.Enter += new System.EventHandler(this.idText_Enter);
            this.idText.Leave += new System.EventHandler(this.idText_Leave);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listView1_PreviewKeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Arrival Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Burst Time";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Priority";
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(6, 142);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "Edit (Ctrl+E)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(6, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(6, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Delete (Del)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(6, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "Down (Alt+Down)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(6, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "UP (Alt+UP)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 270);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listView1_PreviewKeyDown);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Action";
            this.columnHeader5.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Press Ctrl+Shift+I to insert items";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(510, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(7, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(6, 184);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 25);
            this.button8.TabIndex = 16;
            this.button8.Text = "Import";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            // 
            // ManageItems
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 320);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Processes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageItems_FormClosing);
            this.Load += new System.EventHandler(this.ManageItems_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listView1_PreviewKeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.NumericUpDown prText;
        private System.Windows.Forms.NumericUpDown tText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown atText;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}