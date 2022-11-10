namespace WF___PV111
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.zdfgsdfgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdsfgdsfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdsfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfdfgdfgdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfgdfgdfgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sdgsdgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 80);
            this.label2.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(69, 315);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "січень",
            "лютий",
            "березень",
            "квітень",
            "травень"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(183, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Move";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add list";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "e44twert",
            "ert;oete",
            "er;jtwert",
            "rtyrty",
            "wryerty",
            "ertyrtyer",
            "yerywryuetu",
            "rtyer",
            "yretu",
            "ertyityiu",
            "rsyesyr",
            "utietse"});
            this.checkedListBox1.Location = new System.Drawing.Point(324, 13);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(370, 94);
            this.checkedListBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.toolTip2.SetToolTip(this.comboBox1, "Day");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(183, 174);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 19);
            this.progressBar1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.progressBar1, "Progress = 100%");
            this.progressBar1.Value = 50;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBox1.Mask = "(000)000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.toolTip1.SetToolTip(this.maskedTextBox1, "Phone");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(463, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdsfgToolStripMenuItem,
            this.dfgdsfgdsfgToolStripMenuItem,
            this.zdfgsdfgsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgToolStripMenuItem2,
            this.dfgdfgToolStripMenuItem1,
            this.dfgdfgToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // zdfgsdfgsToolStripMenuItem
            // 
            this.zdfgsdfgsToolStripMenuItem.Name = "zdfgsdfgsToolStripMenuItem";
            this.zdfgsdfgsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zdfgsdfgsToolStripMenuItem.Text = "zdfgsdfgs";
            // 
            // dfgdsfgdsfgToolStripMenuItem
            // 
            this.dfgdsfgdsfgToolStripMenuItem.Name = "dfgdsfgdsfgToolStripMenuItem";
            this.dfgdsfgdsfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dfgdsfgdsfgToolStripMenuItem.Text = "dfgdsfgdsfg";
            // 
            // dfgdsfgToolStripMenuItem
            // 
            this.dfgdsfgToolStripMenuItem.Name = "dfgdsfgToolStripMenuItem";
            this.dfgdsfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dfgdsfgToolStripMenuItem.Text = "dfgdsfg";
            // 
            // dfgdfgToolStripMenuItem
            // 
            this.dfgdfgToolStripMenuItem.Name = "dfgdfgToolStripMenuItem";
            this.dfgdfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dfgdfgToolStripMenuItem.Text = "dfgdfg";
            // 
            // dfgdfgToolStripMenuItem1
            // 
            this.dfgdfgToolStripMenuItem1.Name = "dfgdfgToolStripMenuItem1";
            this.dfgdfgToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dfgdfgToolStripMenuItem1.Text = "dfgdfg";
            // 
            // dfgdfgToolStripMenuItem2
            // 
            this.dfgdfgToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfgdfgdfgToolStripMenuItem});
            this.dfgdfgToolStripMenuItem2.Name = "dfgdfgToolStripMenuItem2";
            this.dfgdfgToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.dfgdfgToolStripMenuItem2.Text = "dfgdfg";
            // 
            // dfgdfgdfgToolStripMenuItem
            // 
            this.dfgdfgdfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dfdfgdfgdfToolStripMenuItem,
            this.dfgdfgdfgToolStripMenuItem1});
            this.dfgdfgdfgToolStripMenuItem.Name = "dfgdfgdfgToolStripMenuItem";
            this.dfgdfgdfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dfgdfgdfgToolStripMenuItem.Text = "dfgdfgdfg";
            // 
            // dfdfgdfgdfToolStripMenuItem
            // 
            this.dfdfgdfgdfToolStripMenuItem.Name = "dfdfgdfgdfToolStripMenuItem";
            this.dfdfgdfgdfToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dfdfgdfgdfToolStripMenuItem.Text = "dfdfgdfgdf";
            // 
            // dfgdfgdfgToolStripMenuItem1
            // 
            this.dfgdfgdfgToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdgsdgdfgToolStripMenuItem});
            this.dfgdfgdfgToolStripMenuItem1.Name = "dfgdfgdfgToolStripMenuItem1";
            this.dfgdfgdfgToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dfgdfgdfgToolStripMenuItem1.Text = "dfgdfgdfg";
            // 
            // sdgsdgdfgToolStripMenuItem
            // 
            this.sdgsdgdfgToolStripMenuItem.Name = "sdgsdgdfgToolStripMenuItem";
            this.sdgsdgdfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sdgsdgdfgToolStripMenuItem.Text = "sdgsdgdfg";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(833, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Form1";
            this.Text = "Main";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem dfgdsfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdsfgdsfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zdfgsdfgsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfdfgdfgdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgdfgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sdgsdgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dfgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
    }
}

