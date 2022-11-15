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
    public partial class Form3 : Form
    {
        public string TextEdit {
            get { return textBox1.Text; }
            set
            {
                textBox1.Text = value;
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string t)
        {
            InitializeComponent();
            textBox1.Text= t;
        }

        public DialogResult ShowDialog(Form t)
        {
            this.Owner = t;
            TextEdit = (t as Form2).TextForm2;
            return ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (this.Owner as Form2).textBox1.Text = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
