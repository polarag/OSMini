using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanttChart
{
    public partial class Form1 : Form
    {

        GanttChart ganttChart2;

        private static List<Process> processes = new List<Process>();

        internal static List<Process> Processes { get => processes; set => processes = value; }

        public Form1()
        {
            InitializeComponent();
        }
        private void DrawGantt(List<Process> _processes)
        {
            tableLayoutPanel1.Controls.Clear();
            GenerateGantt();
            ganttChart2.FromDate = DateTime.Now.AddMinutes(_processes[0].arrivaltime);

            int time = _processes[0].arrivaltime;
            // BarInformation("Time: " + _processes[i].time + " units, AT:" + _processes[i].arrivaltime, ganttChart2.FromDate.AddMinutes(_processes[i].arrivaltime), ganttChart2.FromDate.AddMinutes(_processes[i].arrivaltime + _processes[i].time)
            for (int i =0; i < _processes.Count(); i++)
            {
                ganttChart2.AddChartBar("P" + _processes[i].id, new BarInformation("Time: " + _processes[i].time + " units, AT:" + _processes[i].arrivaltime, ganttChart2.FromDate.AddMinutes(_processes[i].arrivaltime > time ? _processes[i].arrivaltime : time), ganttChart2.FromDate.AddMinutes((_processes[i].arrivaltime > time ? _processes[i].arrivaltime : time) + _processes[i].time), Color.Maroon, Color.Wheat, 0), ganttChart2.FromDate.AddMinutes(_processes[i].arrivaltime > time? _processes[i].arrivaltime:time ), ganttChart2.FromDate.AddMinutes((_processes[i].arrivaltime > time ? _processes[i].arrivaltime : time) +_processes[i].time), Color.Maroon, Color.Khaki, i);
                time += _processes[i].time;
            }
            ganttChart2.ToDate = ganttChart2.FromDate.AddMinutes((_processes[_processes.Count - 1].arrivaltime > time ? _processes[_processes.Count-1].arrivaltime : time) + _processes[_processes.Count - 1].time);
            tableLayoutPanel1.Controls.Add(ganttChart2, 0, 0);
        }
        void GenerateGantt()
        {
            ganttChart2 = new GanttChart();
            ganttChart2.Dock = DockStyle.Fill;
            ganttChart2.AllowChange = true;
            ganttChart2.AllowManualEditBar = true;

            ganttChart2.MouseMove += new MouseEventHandler(ganttChart2.GanttChart_MouseMove);
            ganttChart2.MouseMove += new MouseEventHandler(GanttChart2_MouseMove);
            ganttChart2.MouseLeave += new EventHandler(ganttChart2.GanttChart_MouseLeave);
            ganttChart2.ContextMenuStrip = ContextMenuGanttChart1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] scheduling_types = new string[]{"FCFS","SJF Preemptive ","SJF Non Preemptive",
                "Priority Preemptive ","Priority Non Preemptive","Round Robin"};

            schedulerType.Items.AddRange(scheduling_types);
            schedulerType.SelectedIndex = 0;

            SaveImageToolStripMenuItem.Click += new EventHandler(SaveImageToolStripMenuItem_Click);
            /*
            txtLog = new TextBox();
            txtLog.Dock = DockStyle.Fill;
            txtLog.Multiline = true;
            txtLog.Enabled = false;
            txtLog.ScrollBars = ScrollBars.Horizontal;
            tableLayoutPanel1.Controls.Add(txtLog, 0, 1);
            */
            //Second Gantt Chart
           
            
        }
        private void GanttChart2_MouseMove(Object sender, MouseEventArgs e)
        {
            List<string> toolTipText = new List<string>();

            if (ganttChart2.MouseOverRowText != null && ganttChart2.MouseOverRowText != "" && ganttChart2.MouseOverRowValue != null)
            {
                object obj = ganttChart2.MouseOverRowValue;
                string typ = obj.GetType().ToString();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart2.MouseOverRowValue;
                    toolTipText.Add(val.RowText);
                    toolTipText.Add("From " + val.FromTime.ToString("HH:mm"));
                    toolTipText.Add("To " + val.ToTime.ToString("HH:mm"));
                }
                else if (typ.ToLower() == "string")
                {
                    toolTipText.Add(ganttChart2.MouseOverRowValue.ToString());
                }
            }
            else
            {
                toolTipText.Add("EMPTY");
            }

            ganttChart2.ToolTipTextTitle = ganttChart2.MouseOverRowText;
            ganttChart2.ToolTipText = toolTipText;
        }

        private void SaveImageToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            Control chart = null;
            if (menuItem != null)
            {
                ContextMenuStrip calendarMenu = menuItem.Owner as ContextMenuStrip;

                if (calendarMenu != null)
                {
                    chart = calendarMenu.SourceControl;
                }
            }

            SaveImage(chart);
        }

        private void SaveImage(Control control)
        {
            GanttChart gantt = control as GanttChart;
            string filePath = Interaction.InputBox("Where to save the file?", "Save image", "C:\\Temp\\GanttChartTester.jpg");
            if (filePath.Length == 0)
                return;
            gantt.SaveImage(filePath);
            Interaction.MsgBox("Picture saved", MsgBoxStyle.Information);
        }

        private void schedulerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (schedulerType.SelectedItem.ToString() == "Round Robin")
            {
                lblQuantum.Visible = numQuantum.Visible = true;

            }
            else
            {
                lblQuantum.Visible = numQuantum.Visible = false;
            }
        }

        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                Processes.Clear();
                
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    
                    Processes.Add(new Process(i,random.Next(1, 20), random.Next(0, 6),random.Next(0, (int)numericUpDown1.Value *6 )));
                    
                }
                MessageBox.Show("Generated " + numericUpDown1.Value.ToString() + " entries successfully. You can manage the generated entries through Manage Processes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please supply a value that is more than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new ManageItems().ShowDialog();
        }

        private void FCFS()
        {

            Processes = Processes.OrderBy(x => x.arrivaltime).ToList();
            DrawGantt(Processes);
        }
        //0: preemptive
        //1: nonpre
        private void SJF(int mode = 0)
        {

            if (mode == 0) // PREEMPTIVE
            {
                List<Process> scheduledprocess = new List<Process>();


            }


            if (mode == 1 ) // NON PREEmptive
            {

                List<Process> scheduledprocesses = new List<Process>();
                List<Process> orderedprocesses    = processes.OrderBy(o => o.arrivaltime).ToList();
                int accumlatedtime = 0;
                while(orderedprocesses.Count() > 0)
                {
                    
                     Process currentprocess = orderedprocesses.Where(o => o.arrivaltime <= accumlatedtime).OrderBy(o => o.time).FirstOrDefault();
                    if (currentprocess == null) currentprocess = orderedprocesses.OrderBy(o => o.arrivaltime).FirstOrDefault();
                    scheduledprocesses.Add(currentprocess);
                    accumlatedtime += currentprocess.time;
                    orderedprocesses.RemoveAll(x => x == currentprocess );

                }

                DrawGantt(scheduledprocesses);

            }

        }
        private void Priority(int mode = 0)
        {
        }
        private void RoundRobin()
        {

        }
        private void btngenerate_Click(object sender, EventArgs e)
        {
            switch (schedulerType.SelectedIndex)
            {
                case 0:
                    FCFS();
                    break;
                case 1:
                    SJF(0);
                    break;
                case 2:
                    SJF(1);
                    break;
                case 3:
                    Priority(0);
                    break;
                case 4:
                    Priority(1);
                    break;
                case 5:
                    RoundRobin();
                    break;
            }

        }
    }
}
