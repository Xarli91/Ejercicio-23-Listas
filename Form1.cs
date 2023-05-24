using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EJER23LISTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e, listBox1);
        }

        private void button2_Click(object sender, EventArgs e, ListBox listBox1)
        {
            bool lBox = false;
            bool cBox = false;
            bool clBox = false;
            if (radioButton1.Checked)
            {
                lBox = true;
            }
            if (radioButton2.Checked)
            {
                cBox = true;
            }
            else if (radioButton3.Checked)
            {
                clBox = true;
            }

            if (lBox == true)
            {
                listBox1.Items.Add(textBox2.Text);
            }
            if (cBox == true)
            {
                comboBox1.Items.Add(textBox2.Text);
            }
            if (clBox == true)
            {
                checkedListBox1.Items.Add(textBox2.Text);
            }

            label2.Text = listBox1.Items.Count.ToString();
            label3.Text = comboBox1.Items.Count.ToString();
            label4.Text = checkedListBox1.Items.Count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool lBox = false;
            bool cBox = false;
            bool clBox = false;
            if (radioButton1.Checked)
            {
                lBox = true;
            }
            if (radioButton2.Checked)
            {
                cBox = true;
            }
            else if (radioButton3.Checked)
            {
                clBox = true;
            }

            if (lBox == true)
            {
                listBox1.Items.Remove(textBox2.Text);
            }
            if (cBox == true)
            {
                comboBox1.Items.Remove(textBox2.Text);
            }
            if (clBox == true)
            {
                checkedListBox1.Items.Remove(textBox2.Text);
            }

            label2.Text = listBox1.Items.Count.ToString();
            label3.Text = comboBox1.Items.Count.ToString();
            label4.Text = checkedListBox1.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            bool lBox = false;
            bool cBox = false;
            bool clBox = false;
            if (radioButton1.Checked)
            {
                lBox = true;
            }
            if (radioButton2.Checked)
            {
                cBox = true;
            }
            else if (radioButton3.Checked)
            {
                clBox = true;
            }

            if (lBox == true)
            {
                textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
            if (cBox == true)
            {
                textBox1.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            }
            if (clBox == true)
            {
                foreach (var lang in checkedListBox1.CheckedItems)
                {
                    listView1.Items.Add(lang.ToString());
                }
            }
        }
    }
}