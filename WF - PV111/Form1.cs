using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___PV111
{
    public partial class Form1 : Form
    {
        Button b2;
        int x, y;
        Label label1;
        int time;

        BindingList<string> month;

        public Form1()
        {
            InitializeComponent();
            month = new BindingList<string> { "Mo", "Tu", "We" };
            listBox2.DataSource = month;
            //comboBox1.DataSource = month;
            comboBox1.Items.AddRange(new string[] { "Mo", "Tu", "We" });
            //comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox1.KeyPress += (sender, e) => e.Handled = true;

            toolTip2.SetToolTip(textBox1, "New element");
        }

        private void btn_Click_Click(object sender, EventArgs e)
        {
            //b2 = new Button();
            //b2.Size = new Size(100, 100);
            //b2.Location = new Point(200, 200);
            //b2.Text = "Text";
            //b2.Click += B2_Click;
            //this.Controls.Add(b2);

            DialogResult res = MessageBox.Show("Click", "Main form", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            if(res == DialogResult.Abort)
            {
                b2 = new Button();
                b2.Size = new Size(100, 100);
                b2.Location = new Point(200, 200);
                b2.Text = "Text";
                b2.Click += B2_Click;
                this.Controls.Add(b2);

            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            b2.Visible = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.Location.X}, Y = {e.Location.Y}";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            time = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            numericUpDown1.Value = time;
            if(time == 0)
            {
                timer2.Enabled = false;
                MessageBox.Show("Boom!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                month.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            //f.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                x = e.Location.X;
                y = e.Location.Y;
            }
            if(e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right");
            }


        }
    }
}
