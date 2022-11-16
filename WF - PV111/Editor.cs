using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___PV111
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();

            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            openToolStripMenuItem.Text = Resources.Resource1.Open;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt||";
            saveFileDialog1.FilterIndex = 2;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFileDialog1.FileName);
                stream.Write(textBox1.Text.ToString());
                stream.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt||";
            openFileDialog1.FilterIndex = 2;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = stream.ReadToEnd();
                stream.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}
