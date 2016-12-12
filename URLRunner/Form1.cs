using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace URLRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    f.Multiselect = false;
                    string[] l = System.IO.File.ReadAllLines(f.FileName);
                    foreach (string s in l)
                    {
                        string z = s.Trim();
                        if (listBox_urls.Items.Contains(z) || !z.Contains('.'))
                            continue;
                        listBox_urls.Items.Add(z);
                    }
                }
                catch { MessageBox.Show("Error reading file"); }
            }
            buttonClear.Enabled = linkLabelExport.Visible = listBox_urls.Items.Count > 0;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = listBox_urls.SelectedIndex >= 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox_urls.SelectedIndex >= 0)
                listBox_urls.Items.RemoveAt(listBox_urls.SelectedIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox_urls.Items.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buttonAddsIngle.Enabled = Isurl(textBoxFilter.Text);
        }

        private bool Isurl(string p)
        {
            p = p.Trim();
            if (p.StartsWith("http://") == false && p.StartsWith("https://") == false)
                p = "http://" + p;

            if (p.Contains('.')&&p.Length>=12)
                return false;
            return true;
        }

        private void radioButtonHTTP_CheckedChanged(object sender, EventArgs e)
        {
            checkFilter();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkFilter();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkFilter();
        }

        private void checkFilter()
        {
            buttonFilter.Enabled = (radioButtonContains.Checked&&textBoxFilter.TextLength>1) || radioButtonHTTPS.Checked || radioButtonHTTP.Checked;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            int ind=0;
            string ptrn = textBoxFilter.Text.Trim();
            foreach (var i in listBox_urls.Items)
            {
                string item = i.ToString();
                bool matched = false;
                if (radioButtonHTTP.Checked)
                    matched = item.StartsWith("http:");

                else if (radioButtonHTTPS.Checked)
                    matched = item.StartsWith("https:");

                else if (radioButtonContains.Checked)
                    matched = item.Contains(ptrn);

                
                if(matched)
                    listBox_urls.Items.RemoveAt(ind);

                    ind++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTimeUnit.SelectedIndex = 1;
        }

        private void comboBoxTimeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTimeUnit.SelectedIndex == 3)
                this.interval = 1;
            if (comboBoxTimeUnit.SelectedIndex == 1)
                this.interval = 1000;

            if (comboBoxTimeUnit.SelectedIndex == 2)
                this.interval = 1000*60;

            if (comboBoxTimeUnit.SelectedIndex == 3)
                this.interval = 1000*60*60;
        }

        public int interval = 0;

        private void buttonAddsIngle_Click(object sender, EventArgs e)
        {
            string ni = textBoxSingle.Text.Trim() ;
            if (!ni.StartsWith("http://") && !ni.StartsWith("https://"))
                ni = "http://" + ni;
            if (listBox_urls.Items.Contains(ni) == false && ni.Length>="http://go.go".Length)
            {
                listBox_urls.Items.Add(ni);

                textBoxSingle.Text = "";
            }
            buttonClear.Enabled =linkLabelExport.Visible= listBox_urls.Items.Count > 0;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (radioButtonCustom.Checked && this.CustomeBrowser == "")
            {
                linkLabel1_LinkClicked(null, null);
                if (System.IO.File.Exists(this.CustomeBrowser))
                    buttonRun_Click(null, null);
            }
            else
            {
                foreach(string s in listBox_urls.Items)
                {
                    try
                    {
                        if (radioButtonCustom.Checked)
                        {

                            System.Diagnostics.Process.Start(this.CustomeBrowser, s);
                        }
                        else if (radioButtonDefault.Checked)
                        {
                            System.Diagnostics.Process.Start(s);
                        }
                        else if (radioButtonEmbededBrowser.Checked)
                        {
                            RunEmbededPage(s);

                        }
                    }
                    catch { }
                    System.Threading.Thread.Sleep(((int)numericUpDown1.Value) * this.interval);
            }
        }
            }

        private void RunEmbededPage(string u)
        {
            this.textBoxBEmbededURl.Text = u;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = @"C:\Program Files\";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.CustomeBrowser = o.FileName;

        }

        public string CustomeBrowser ="";

        private void textBoxBEmbededURl_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxBEmbededURl.Text);
        }

        private void linkLabelExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "urls.txt";
            string data = "";
            if (s.ShowDialog() == DialogResult.OK)
            {
                foreach (string l in listBox_urls.Items)
                {
                    data += l + "\r\n";
                }
                try
                {
                    System.IO.File.WriteAllText(s.FileName, data);
                    MessageBox.Show("", "Saved to " + s.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch {
                    MessageBox.Show("", "Error occured while Saving to " + s.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
        }
    }
}
