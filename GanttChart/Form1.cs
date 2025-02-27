﻿using GanttChart;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
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
                ganttChart2.FromDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00",System.Globalization.CultureInfo.InvariantCulture).AddMinutes(_processes[0].arrivaltime);

                int time = _processes[0].arrivaltime;
                // BarInformation("Time: " + _processes[i].time + " units, AT:" + _processes[i].arrivaltime, ganttChart2.FromDate.AddMinutes(_processes[i].arrivaltime), ganttChart2.FromDate.AddMinutes(_processes[i].arrivaltime + _processes[i].time)
                int startT = 0;
                int endT = 0;
                Process originalP;
                float waitingTime = 0;
            Dictionary<int,int> FinalEndTime = new Dictionary<int, int>();
            for (int i =0; i < _processes.Count(); i++)
                {
                originalP = Processes.Where(p => p.id == _processes[i].id).FirstOrDefault();
                    startT = _processes[i].arrivaltime > time ? _processes[i].arrivaltime : time;
                    endT = (_processes[i].arrivaltime > time ? _processes[i].arrivaltime : time) + _processes[i].time;
                    ganttChart2.AddChartBar("P" + _processes[i].id, new BarInformation("Start: " + startT +  ", End: " + endT + ",|Time: " + _processes[i].time + " units, AT:" + originalP.arrivaltime, ganttChart2.FromDate.AddMinutes(startT), ganttChart2.FromDate.AddMinutes(endT), _processes[i].color != Color.White? _processes[i].color : Color.Maroon, Color.Wheat, 0), ganttChart2.FromDate.AddMinutes(startT), ganttChart2.FromDate.AddMinutes(endT), _processes[i].color != Color.White ? _processes[i].color : Color.Maroon, Color.Khaki, i);
                    time = endT;
                if (FinalEndTime.ContainsKey(_processes[i].id) == true)
                {
                    if (FinalEndTime[_processes[i].id] < endT) FinalEndTime[_processes[i].id] = endT;
                    
                }
                else
                {
                    FinalEndTime.Add(_processes[i].id, endT);
                }
                }
            
            waitingTime = FinalEndTime.Sum(x => x.Value) - Processes.Sum(n => n.arrivaltime) - Processes.Sum(o => o.time);
            label2.Text = "Average Waiting Time: " + (waitingTime*1.0/Processes.Count()).ToString("0.00");

            label2.Visible = true;
            ganttChart2.ToDate = ganttChart2.FromDate.AddMinutes((_processes[_processes.Count - 1].arrivaltime > time ? _processes[_processes.Count-1].arrivaltime : time) + _processes[_processes.Count - 1].time);
                tableLayoutPanel1.Controls.Add(ganttChart2, 0, 0);
            }
        void GenerateGantt()
        {
            if (ganttChart2 != null)
            ganttChart2.Dispose();
            GanttChart ganttChart = new GanttChart();
            ganttChart.AllowChange = false;
            ganttChart.Dock = DockStyle.Fill;
            
            ganttChart.MouseMove += new MouseEventHandler(ganttChart.GanttChart_MouseMove);
            ganttChart.MouseMove += new MouseEventHandler(GanttChart2_MouseMove);
            ganttChart.MouseDragged += new MouseEventHandler(ganttChart.GanttChart_MouseDragged);
            ganttChart.MouseLeave += new EventHandler(ganttChart.GanttChart_MouseLeave);

            ganttChart.ContextMenuStrip = ContextMenuGanttChart1;
            ganttChart2 = ganttChart;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] scheduling_types = new string[]{"FCFS","SJF Preemptive ","SJF Non Preemptive",
                "Priority Preemptive ","Priority Non Preemptive","Round Robin"};

            schedulerType.Items.AddRange(scheduling_types);
            schedulerType.SelectedIndex = 0;

            SaveImageToolStripMenuItem.Click += new EventHandler(SaveImageToolStripMenuItem_Click);
          
            
        }
        private void GanttChart2_MouseMove(Object sender, MouseEventArgs e)
        {

            if (ganttChart2.MouseOverRowText != null && ganttChart2.MouseOverRowText != "" && ganttChart2.MouseOverRowValue != null)
            {
                object obj = ganttChart2.MouseOverRowValue;
                string typ = obj.GetType().ToString();
                List<string> toolTipText = new List<string>();
                if (typ.ToLower().Contains("barinformation"))
                {
                    BarInformation val = (BarInformation)ganttChart2.MouseOverRowValue;
                    if (val.RowText.Contains("|"))
                    {
                        string[] split = val.RowText.Split('|');
                        foreach (string item in split) toolTipText.Add(item);
                    }
                    else
                    {
                        toolTipText.Add(val.RowText);
                    }
                    toolTipText.Add("From " + val.FromTime.ToString("HH:mm"));
                    toolTipText.Add("To " + val.ToTime.ToString("HH:mm"));
                }
                else if (typ.ToLower() == "string")
                {
                    toolTipText.Add(ganttChart2.MouseOverRowValue.ToString());
                }
                ganttChart2.ToolTipTextTitle = ganttChart2.MouseOverRowText;
                ganttChart2.ToolTipText = toolTipText;
            }

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
            DrawGantt(Processes.OrderBy(x => x.arrivaltime).ToList());
        }
        //0: preemptive
        //1: nonpre
        private void SJF(int mode = 0)
        {
            if (mode == 0) // PREEMPTIVE
            {
                List<Process> groupprocess;
                List<Process> scheduledprocesses = new List<Process>();
                List<Process> orderedprocesses = Clone(processes);
                int accumlatedtime = 0;
                Process currentprocess;
                while (orderedprocesses.Count() > 0)
                {
                    groupprocess = orderedprocesses.Where(o => o.arrivaltime <= accumlatedtime).OrderBy(o => o.time).ToList();
                    
                    currentprocess = groupprocess.FirstOrDefault();
                    if (currentprocess == null) { accumlatedtime++; continue; }
                    scheduledprocesses.Add(new Process(currentprocess.id, 1, 0, accumlatedtime));
                    accumlatedtime++;
                    currentprocess.time--;
                    orderedprocesses.RemoveAll(x => x.time <= 0);

                }
                for (int i = scheduledprocesses.Count() - 1; i > 0; i--)
                {
                    if (scheduledprocesses[i].id == scheduledprocesses[i - 1].id)
                    {
                        scheduledprocesses[i - 1].time += scheduledprocesses[i].time;
                        scheduledprocesses.Remove(scheduledprocesses[i]);
                    }
                }
                DrawGantt(scheduledprocesses);

            }
            else // NON PREEmptive
            {
                
                List<Process> scheduledprocesses = new List<Process>();
                List<Process> orderedprocesses = Clone(processes).OrderBy(o => o.arrivaltime).ToList();
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
                

                /*DrawGantt(Processes.OrderBy(x => x.arrivaltime).ThenBy(x => x.time).ToList());*/
            }
                
        }
        private void Priority(int mode = 0)
        {
            if (mode == 0)
            {

                List<Process> groupprocess;
                List<Process> scheduledprocesses = new List<Process>();
                List<Process> orderedprocesses = Clone(processes);
                int accumlatedtime = 0;
                Process currentprocess;
                while (orderedprocesses.Count() > 0)
                {
                    groupprocess = orderedprocesses.Where(o => o.arrivaltime <= accumlatedtime).OrderBy(o => o.priority).ToList();

                    currentprocess = groupprocess.FirstOrDefault();
                    if (currentprocess == null) { accumlatedtime++; continue; }
                    scheduledprocesses.Add(new Process(currentprocess.id, 1, currentprocess.priority, accumlatedtime));
                    accumlatedtime++;
                    currentprocess.time--;
                    orderedprocesses.RemoveAll(x => x.time <= 0);
                }
                for (int i = scheduledprocesses.Count() - 1; i > 0; i--)
                {
                    if (scheduledprocesses[i].id == scheduledprocesses[i - 1].id)
                    {
                        scheduledprocesses[i - 1].time += scheduledprocesses[i].time;
                        scheduledprocesses.Remove(scheduledprocesses[i]);
                    }
                }
                DrawGantt(scheduledprocesses);
            }
            else
            {
                DrawGantt(Processes.OrderBy(x => x.arrivaltime).ThenBy(x => x.priority).ToList());
            }
        }
        private List<Process> Clone(List<Process> _processes)
        {
            List<Process> result = new List<Process>();
            foreach (Process p in _processes)
                result.Add(new Process(p.id, p.time, p.priority, p.arrivaltime));
            return result;
        }
        private void RoundRobin()
        {
            int q = (int)numQuantum.Value;
            if (q > 0)
            {
                List<Process> scheduledprocesses = new List<Process>();
                List<Process> orderedprocesses = Clone(processes.OrderBy(o => o.arrivaltime).ToList()); //clone

                bool _break = true;
                int sumq = orderedprocesses[0].arrivaltime;
                int subtract = 0;
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                while (orderedprocesses.Count() > 0)
                {
                    _break = true;
                    for (int i = 0; i < orderedprocesses.Count(); i++)
                    {
                        if (orderedprocesses[i].time > 0)
                        {
                            subtract = orderedprocesses[i].time >= q ? q : orderedprocesses[i].time;
                            if (q != (int)numQuantum.Value) { q = (int)numQuantum.Value; }
                            if (orderedprocesses[i].time < q) q -= orderedprocesses[i].time;
                            orderedprocesses[i].time -= subtract;
                            sumq = (orderedprocesses[i].arrivaltime > sumq ? orderedprocesses[i].arrivaltime : sumq) + subtract;
                            scheduledprocesses.Add(new Process(orderedprocesses[i].id, subtract, orderedprocesses[i].priority, orderedprocesses[i].arrivaltime, color));
                            if (q == (int)numQuantum.Value) color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                            _break = false;
                            if (orderedprocesses.Count() > i + 1 && orderedprocesses[i + 1].arrivaltime - (sumq + subtract - 1) >= 0) i = orderedprocesses.IndexOf(orderedprocesses.FirstOrDefault(p => p.time > 0)) - 1;

                        }
                    }
                    if (_break) break;
                }
                DrawGantt(scheduledprocesses);
            }
            else
            {
                MessageBox.Show("Please supply a positive non-zero quantum.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btngenerate_Click(object sender, EventArgs e)
        {
            if (processes.Count() > 0)
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
            else
            {
                MessageBox.Show("Please insert one or more processses to schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
