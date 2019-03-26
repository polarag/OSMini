using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class ManageItems : Form
    {
        public ManageItems()
        {
            InitializeComponent();
        }
        public static ListView lv;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        string SelectedItem;
        int SelectedIndex;
        ListViewItem selected;
        int index = 0;
        private void button4_Click_1(object sender, EventArgs e)
        {
            SwitchSides("UP", sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {

            SwitchSides("DOWN", sender);
        }

        private void SwitchSides(string Mode, object sender)
        {
            if (Mode == "UP")
            {
                if (SelectedItem != "" && 0 < SelectedIndex)
                {
                    listView1.Items.RemoveAt(SelectedIndex);
                    listView1.Items.Insert(SelectedIndex - 1, selected);
                    listView1.Update();
                }
            }
            else if (Mode == "DOWN" && SelectedItem != "" && listView1.Items.Count - 1 > SelectedIndex)
            {
                listView1.Items.RemoveAt(SelectedIndex);
                listView1.Items.Insert(SelectedIndex + 1, selected);
                listView1.Update();
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectedItem = e.Item.Text;
            SelectedIndex = e.ItemIndex;
            selected = e.Item;
        }
        string PostMethod = "Add";
        private void DoMethod()
        {
            setVisibleNumeric(true);
            DisableRightPane();
            splitContainer2.Panel2.Enabled = false;
            listView1.Enabled = false;
            listView2.Enabled = false;
            try
            {
                if (PostMethod != "Add")
                {
                    idText.Location = new Point(listView1.Items[SelectedIndex].Position.X, listView1.Items[SelectedIndex].Position.Y);
                    atText.Location = new Point(listView1.Items[SelectedIndex].Position.X + columnHeader1.Width, listView1.Items[SelectedIndex].Position.Y);
                    tText.Location = new Point(listView1.Items[SelectedIndex].Position.X + columnHeader2.Width + columnHeader1.Width, listView1.Items[SelectedIndex].Position.Y);
                    prText.Location = new Point(listView1.Items[SelectedIndex].Position.X + columnHeader3.Width + columnHeader2.Width + columnHeader1.Width, listView1.Items[SelectedIndex].Position.Y);

                }
                else if (listView1.Items.Count > 0)
                {
                    idText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                    atText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X + columnHeader1.Width, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                    tText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X + columnHeader2.Width + columnHeader1.Width, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                    prText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X + columnHeader3.Width + columnHeader2.Width + columnHeader1.Width, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                }
                else
                {
                    idText.Location = new Point(5, 30);
                    atText.Location = new Point(69, 30);
                    tText.Location = new Point(170, 30);
                    prText.Location = new Point(250, 30);
                }
            }
            catch
            {
                if (listView1.Items.Count > 0)
                {

                    idText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                    tText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X + columnHeader1.Width, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                    prText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X + columnHeader2.Width + columnHeader1.Width, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                    atText.Location = new Point(listView1.Items[listView1.Items.Count - 1].Position.X + columnHeader3.Width + columnHeader2.Width + columnHeader1.Width, listView1.Items[listView1.Items.Count - 1].Position.Y + 17);
                }
            }
            idText.Size = new Size(columnHeader1.Width - 5, idText.Size.Height);
            atText.Size = new Size(columnHeader2.Width - 5, idText.Size.Height);
            tText.Size = new Size(columnHeader3.Width - 5, idText.Size.Height);
            prText.Size = new Size(columnHeader4.Width - 5, idText.Size.Height);

            atText.Select();
            atText.Focus();
            try
            {
                idText.Text = PostMethod == "Add" ? (index + 1).ToString() : listView1.Items[SelectedIndex].SubItems[0].Text;

                atText.Value = int.Parse(listView1.Items[SelectedIndex].SubItems[1].Text);
                tText.Value = int.Parse(listView1.Items[SelectedIndex].SubItems[2].Text);
                prText.Value = int.Parse(listView1.Items[SelectedIndex].SubItems[3].Text);
            }
            catch
            {
                if (PostMethod == "Add")
                    idText.Text = (index + 1).ToString();
            }
            listView1.Scrollable = true;
            if (listView1.Items.Count > 0)
            {
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            PostMethod = "Add";
            DoMethod();
        }

        private void DisableRightPane()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button2.Enabled = false;
        }


        private void EnableRightPane()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button2.Enabled = true;
        }
        private void setVisibleNumeric(bool visible)
        {
            foreach (Control control in splitContainer2.Panel1.Controls)
            {
                if (control is NumericUpDown || control is TextBox)
                    control.Visible = visible;
            }

            DoneButton.Visible = visible;
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (PostMethod == "Edit")
            {
                if (idText.Text != "")
                {
                    listView1.Enabled = true;
                    listView2.Enabled = true;
                    try
                    {
                        listView1.Items[SelectedIndex].SubItems.Clear();
                        listView1.Items[SelectedIndex].SubItems[0].Text = idText.Text;
                        SelectedItem = listView1.Items[SelectedIndex].SubItems[0].Text;
                        selected = listView1.Items[SelectedIndex];
                    }
                    catch
                    {
                    }
                    listView1.Items[SelectedIndex].SubItems.Add(atText.Value.ToString());
                    listView1.Items[SelectedIndex].SubItems.Add(tText.Value.ToString());
                        listView1.Items[SelectedIndex].SubItems.Add(prText.Value.ToString());
                  
                    setVisibleNumeric(false);
                    base.AcceptButton = button1;
                    splitContainer2.Panel2.Enabled = true;
                    EnableRightPane();
                    listView1.Focus();
                    listView1.Scrollable = true;
                }
            }
            else if (PostMethod == "Add")
            {
                if (idText.Text != "")
                {
                    listView1.Scrollable = true;
                    if (listView1.Items.Count > 0)
                    {
                        listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                    }
                    listView1.Enabled = true;
                    listView2.Enabled = true;
                    AddItem(int.Parse(idText.Text), (int)atText.Value, (int)tText.Value, (int)prText.Value);
                    setVisibleNumeric(false);
                    base.AcceptButton = button1;
                    splitContainer2.Panel2.Enabled = true;
                    EnableRightPane();
                    listView1.Focus();
                    try
                    {
                        listView1.SelectedIndices.Clear();
                        listView1.SelectedIndices.Add(listView1.Items.Count - 1);
                    }
                    catch
                    {
                        if (listView1.Items.Count > 0)
                        {
                            listView1.SelectedIndices.Add(SelectedIndex);
                        }
                    }
                }
                index++;
                listView1.Scrollable = true;
                if (listView1.Items.Count > 0)
                {
                    listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                }
            }
        }

        private void idText_Enter(object sender, EventArgs e)
        {
            AcceptButton = DoneButton;
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }
    

        private void tText_Enter(object sender, EventArgs e)
        {

            AcceptButton = DoneButton;
        }

        private void prText_Enter(object sender, EventArgs e)
        {
            AcceptButton = DoneButton;
        }

        private void idText_Leave(object sender, EventArgs e)
        {
            base.AcceptButton = button1;
        }

        private void tText_Leave(object sender, EventArgs e)
        {

            base.AcceptButton = button1;
        }

        private void prText_Leave(object sender, EventArgs e)
        {
            base.AcceptButton = button1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PostMethod = "Edit";
            DoMethod();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (SelectedItem != "")
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    listView1.Items.RemoveAt(selectedItem.Index);
                }
                SelectedIndex = 0;
                selected = null;
                SelectedItem = "";
                listView1.Update();
            }
            if (listView1.Items.Count == 0)
                button3.Enabled = false;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (listView2.Enabled)
            {
                if (e.Control && e.Shift && e.KeyValue == 73)
                {
                    button2_Click_1(sender, e);
                }
                else if (e.Control && e.KeyValue == 69 && SelectedItem != "")
                {
                    button7_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    button6_Click(sender, e);
                }

                else if (e.Control && e.KeyCode == Keys.A)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        item.Selected = true;
                    }
                }
                else if (e.Alt && e.KeyValue == 38)
                {
                    SwitchSides("UP", sender);
                }
                else if (e.Alt && e.KeyValue == 40)
                {
                    SwitchSides("DOWN", sender);
                }
                else if (e.KeyCode == Keys.Escape && PostMethod != "Edit")
                {
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Processes.Clear();
         
            foreach (ListViewItem item in listView1.Items)
                Form1.Processes.Add(new Process(int.Parse(item.Text), int.Parse(item.SubItems[2].Text), int.Parse(item.SubItems[3].Text), int.Parse(item.SubItems[1].Text)));
           
            if (e.GetType().ToString() != "System.Windows.Forms.FormClosingEventArgs")
            Close();
        }
        private void AddItem(int id, int AT, int BT, int p)
        {
            ListViewItem item = new ListViewItem();
            item.Text = id.ToString();
            item.SubItems.Add(AT.ToString());
            item.SubItems.Add(BT.ToString());
            item.SubItems.Add(p.ToString());
            listView1.Items.Add(item);

            button3.Enabled = true;
        }
        private void ManageItems_Load(object sender, EventArgs e)
        {
            foreach (Process process in Form1.Processes)
            {
                ListViewItem item = new ListViewItem();
                AddItem(process.id, process.arrivaltime, process.time, process.priority);
                if (process.id > index) index = process.id;
            }

        }
        private void ManageItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog1.FileName);
                string line;
                string[] split;
                while ((line = reader.ReadLine()) != null)
                {
                    split = line.Split(',');
                    if (split.Length > 2)
                    {
                        try
                        {
                            AddItem(++index, int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]));
                        }
                        catch { }
                    }
                }
                reader.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName);
                foreach (ListViewItem item in listView1.Items)
                {
                    writer.WriteLine(item.SubItems[1].Text + "," + item.SubItems[2].Text + "," + item.SubItems[3].Text);
                }
                writer.Flush();
                writer.Close();
            }

        }
    }
}
