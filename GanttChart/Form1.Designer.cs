namespace Scheduler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ContextMenuGanttChart1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblnoofprocesses = new System.Windows.Forms.Label();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.numQuantum = new System.Windows.Forms.NumericUpDown();
            this.lblSchedulingType = new System.Windows.Forms.Label();
            this.schedulerType = new System.Windows.Forms.ComboBox();
            this.ContextMenuGanttChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuGanttChart1
            // 
            this.ContextMenuGanttChart1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuGanttChart1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveImageToolStripMenuItem});
            this.ContextMenuGanttChart1.Name = "ContextMenuGanttChart1";
            this.ContextMenuGanttChart1.Size = new System.Drawing.Size(135, 26);
            // 
            // SaveImageToolStripMenuItem
            // 
            this.SaveImageToolStripMenuItem.Name = "SaveImageToolStripMenuItem";
            this.SaveImageToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.SaveImageToolStripMenuItem.Text = "Save image";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 194);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblQuantum);
            this.splitContainer1.Panel1.Controls.Add(this.btngenerate);
            this.splitContainer1.Panel1.Controls.Add(this.numQuantum);
            this.splitContainer1.Panel1.Controls.Add(this.lblSchedulingType);
            this.splitContainer1.Panel1.Controls.Add(this.schedulerType);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(481, 350);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Average Waiting Time:";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lblnoofprocesses);
            this.groupBox1.Location = new System.Drawing.Point(14, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 66);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Processes";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(325, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "Manage Processes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "OR";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(181, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Generate Random";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblnoofprocesses
            // 
            this.lblnoofprocesses.AutoSize = true;
            this.lblnoofprocesses.Location = new System.Drawing.Point(5, 22);
            this.lblnoofprocesses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoofprocesses.Name = "lblnoofprocesses";
            this.lblnoofprocesses.Size = new System.Drawing.Size(88, 13);
            this.lblnoofprocesses.TabIndex = 12;
            this.lblnoofprocesses.Text = "No. of Processes";
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Location = new System.Drawing.Point(11, 110);
            this.lblQuantum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(50, 13);
            this.lblQuantum.TabIndex = 21;
            this.lblQuantum.Text = "Quantum";
            this.lblQuantum.Visible = false;
            // 
            // btngenerate
            // 
            this.btngenerate.AutoSize = true;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btngenerate.Location = new System.Drawing.Point(385, 103);
            this.btngenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(85, 26);
            this.btngenerate.TabIndex = 13;
            this.btngenerate.Text = "Schedule";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // numQuantum
            // 
            this.numQuantum.Location = new System.Drawing.Point(63, 108);
            this.numQuantum.Name = "numQuantum";
            this.numQuantum.Size = new System.Drawing.Size(317, 20);
            this.numQuantum.TabIndex = 20;
            this.numQuantum.Visible = false;
            // 
            // lblSchedulingType
            // 
            this.lblSchedulingType.AutoSize = true;
            this.lblSchedulingType.Location = new System.Drawing.Point(11, 9);
            this.lblSchedulingType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchedulingType.Name = "lblSchedulingType";
            this.lblSchedulingType.Size = new System.Drawing.Size(87, 13);
            this.lblSchedulingType.TabIndex = 10;
            this.lblSchedulingType.Text = "Scheduling Type";
            // 
            // schedulerType
            // 
            this.schedulerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schedulerType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.schedulerType.FormattingEnabled = true;
            this.schedulerType.Location = new System.Drawing.Point(106, 6);
            this.schedulerType.Margin = new System.Windows.Forms.Padding(2);
            this.schedulerType.Name = "schedulerType";
            this.schedulerType.Size = new System.Drawing.Size(153, 21);
            this.schedulerType.TabIndex = 9;
            this.schedulerType.SelectedIndexChanged += new System.EventHandler(this.schedulerType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btngenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 350);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OSMini: Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContextMenuGanttChart1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ContextMenuStrip ContextMenuGanttChart1;
        internal System.Windows.Forms.ToolStripMenuItem SaveImageToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSchedulingType;
        private System.Windows.Forms.ComboBox schedulerType;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblnoofprocesses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.NumericUpDown numQuantum;
        private System.Windows.Forms.Label label2;
    }
}

