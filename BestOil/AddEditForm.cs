using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class AddEditForm : Form
    {
        public string ProductName 
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; } 
        }

        public double ProductPrice
        {
            get { return Convert.ToDouble(textBox2.Text.Replace(',', '.')); }
            set { textBox2.Text = value.ToString(); }
        }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
