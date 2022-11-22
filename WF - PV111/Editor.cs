using System;
using System.Collections;
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

        Student[] students =
        {
            new Student()
            {
                FirstName = "Olga",
                LastName = "Petrova",
                BirthDay = new DateTime(2000, 10, 15),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123456
                }
            },
            new Student()
            {
                FirstName = "Valery",
                LastName = "Matveev",
                BirthDay = new DateTime(2001, 11, 5),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123400
                }
            },
            new Student()
            {
                FirstName = "Petro",
                LastName = "Alekseev",
                BirthDay = new DateTime(2000, 10, 14),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123489
                }
            },
            new Student()
            {
                FirstName = "Irina",
                LastName = "Fadeeva",
                BirthDay = new DateTime(1999, 2, 24),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123455
                }
            }
        };



        public Editor()
        {
            InitializeComponent();

            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            openToolStripMenuItem.Text = Resources.Resource1.Open;

            listView1.Columns.Add("FirstName");
            listView1.Columns.Add("LastName");
            listView1.Columns.Add("Date");
            listView1.Columns.Add("Series");
            listView1.Columns.Add("Number");

            for (int i = 0; i < students.Length; i++)
            {
                listView1.Items.Add(students[i].FirstName);
                listView1.Items[i].SubItems.Add(students[i].LastName);
                listView1.Items[i].SubItems.Add(students[i].BirthDay.ToShortDateString());
                listView1.Items[i].SubItems.Add(students[i].StudentCard.Series);
                listView1.Items[i].SubItems.Add(students[i].StudentCard.Number.ToString());
            }
            listView1.View = View.Details;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "All files (*.*)|*.*|RTF files (*.rtf)|*.rtf||";
            saveFileDialog1.FilterIndex = 2;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFileDialog1.FileName);
                stream.Write(richTextBox1.Text.ToString());
                stream.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*|RTF files (*.rtf)|*.rtf||";
            openFileDialog1.FilterIndex = 2;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = stream.ReadToEnd();
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
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14), Brushes.Black, 0, 0);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = fontDialog1.Color;
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        int i = 0; 

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            while(richTextBox1.Text.IndexOf("double", i) != -1)
            {
                i = richTextBox1.Text.IndexOf("double", i);
                richTextBox1.Select(i, 6);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.Select(richTextBox1.Text.Length, 0);
                richTextBox1.SelectionColor = Color.Black;
                i += "double".Length;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TreeView tr = (TreeView)sender;
            //if (tr != null)
            //{
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            //}
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
            }
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
        }
    }


    [Serializable]
    public class StudentCard : IComparable, ICloneable
    {

        public string Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            StudentCard st1 = obj as StudentCard;
            if (Series == st1.Series)
            {
                return Number.CompareTo(st1.Number);
            }
            else
            {
                return Series.CompareTo(st1.Series);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Series} #{Number}";
        }
    }

    class GroupName
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Student : IComparable<Student>, ICloneable
    {
        int id = 100;
        public int GroupName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard StudentCard { get; set; }

        

 
        public override int GetHashCode()
        {
            return $"{StudentCard.Series} #{StudentCard.Number}".GetHashCode();
        }

        public int CompareTo(Student obj) => LastName.CompareTo(obj.LastName);


        public override string ToString()
        {
            return $"{FirstName.PadRight(10)} {LastName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public object Clone()
        {
            Student student = (Student)this.MemberwiseClone();
            student.StudentCard = (StudentCard)this.StudentCard.Clone();
            return student;
        }

        public void Exam(DateTime date)
        {
            Console.WriteLine($"Екзамен для {FirstName} {LastName} назначений на {date.ToShortDateString()}");
        }

    }

    class ExamEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
    }
}
