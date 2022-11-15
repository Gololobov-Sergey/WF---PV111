using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestOil
{
    
    public partial class BestOil : Form
    {
        List<string> names = new List<string> { "A-76", "A-92", "A-95", "Дизель", "Газ", "A-44", "A-80" };
        List<double> prices = new List<double> { 6.40, 7.80, 9.00, 5.00, 3.46, 5.65, 7.15 };

        List<string> namesProduct = new List<string> { "Кофе", "Чай", "Булочка", "Ватрушка", "Пирожок", "Кока-Кола", "Фанта" };
        List<double> pricesProduct = new List<double> { 6.40, 7.80, 9.00, 5.00, 3.46, 5.65, 7.15 };

        double totalIncome = 0;
        Timer timer = new Timer();

        List<Product> products = new List<Product>();

        public BestOil(bool admin)
        {
            InitializeComponent();

            timer.Tick += Timer_Tick;
            timer.Interval = 10000;

            #region Oil and Prices
            comboBox1.DataSource = names;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
            textBox1.Text = prices[0].ToString();
            Price1.Text = "0,00";
            Btn_Calculate.Click += Btn_Calculate_Click;
            #endregion

            #region Food
            for (int i = 0; i < namesProduct.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(8, 12 + i * 28);
                checkBox.Text = namesProduct[i];
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                TextBox textBoxPrice = new TextBox();
                textBoxPrice.Location = new Point(109, 12 + i * 28);
                textBoxPrice.Size = new Size(65, 22);
                textBoxPrice.Text = pricesProduct[i].ToString();
                textBoxPrice.ReadOnly = true;

                NumericUpDown numericUpDownAmount = new NumericUpDown();
                numericUpDownAmount.Location = new Point(190, 12 + i * 28);
                numericUpDownAmount.Size = new Size(65, 22);
                numericUpDownAmount.Minimum = 0;
                numericUpDownAmount.Maximum = 1000;
                numericUpDownAmount.Enabled = false;
                numericUpDownAmount.ValueChanged += NumericUpDownAmount_ValueChanged;

                products.Add(new Product
                {
                    Name = namesProduct[i],
                    Price = (decimal)pricesProduct[i],
                    CheckBox_Enable = checkBox,
                    TextBox_Price = textBoxPrice,
                    Amount = numericUpDownAmount
                });

                panel1.Controls.Add(numericUpDownAmount);
                panel1.Controls.Add(checkBox);
                panel1.Controls.Add(textBoxPrice);

            }

            Price2.Text = "0,00";
            #endregion

            #region Payment for oil
            Quantity.CheckedChanged += Quantity_CheckedChanged;
            OilSum.CheckedChanged += OilSum_CheckedChanged;
            QuantityText.Enabled = false;
            SumText.Enabled = false;
            #endregion

            #region Style
            //Picture.ImageLocation = "scrudge.jpg";
            this.FormClosing += BestOil_FormClosing;
            #endregion

            if(admin)
            {
                PriceOptions.Visible = false;
                QuantityText.Visible = false;
                SumText.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                FoodPrice2.Visible = false;
                FoodPrice.Visible = false;
                FinalPrice.Visible = false;
                Station.Size = new Size(265, 247);
                Cafe.Size = new Size(292, 247);
                this.MinimumSize = new Size(650, 350);
                this.Size = new Size(650, 350);
                panel2.Visible = true;
                panel3.Visible = true;

            }
        }

        private void NumericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal SumAll = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox_Enable.Checked == true)
                {
                    SumAll += products[i].Price * products[i].Amount.Value;
                }
            }
            Price2.Text = String.Format("{0:0.00}", SumAll);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].CheckBox_Enable == check)
                {
                    products[i].Amount.Enabled = check.Checked;
                    NumericUpDownAmount_ValueChanged(sender, e);
                    break;
                }
            }
        }

        private void BestOil_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Tolal income for the day: {totalIncome} грн", "BestOil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            double res;
            if (OilSum.Checked)
            {
                res = Convert.ToDouble(SumText.Text) + Convert.ToDouble(Price2.Text);
            }
            else
            {
                res = Convert.ToDouble(Price1.Text) + Convert.ToDouble(Price2.Text);
            }
            totalIncome += res;
            label9.Text = String.Format("{0:0.00}", res);
            if (!timer.Enabled)
            {
                timer.Start();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to clear the form?", "BestOil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                timer.Stop();
                comboBox1.SelectedIndex = 0;
                Quantity.Checked = false;
                OilSum.Checked = false;
                QuantityText.Text = "";
                SumText.Text = "";
                Price1.Text = "0,00";
                foreach (var item in products)
                {
                    item.Amount.Value = 0;
                    item.Amount.Enabled = false;
                    item.CheckBox_Enable.Checked = false;
                }
                label9.Text = "";
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.DataSource == null)
                return;
            textBox1.Text = prices[comboBox1.SelectedIndex].ToString();
            if (Quantity.Checked)
            {
                var temp = QuantityText.Text;
                QuantityText.Text = "";
                QuantityText.Text = temp;
            }
            else if (OilSum.Checked)
            {
                var temp = SumText.Text;
                SumText.Text = "";
                SumText.Text = temp;
            }
        }

        private void OilSum_CheckedChanged(object sender, EventArgs e)
        {
            if (OilSum.Checked)
            {
                FoodPrice2.Text = "До видачі:";
                label5.Text = "л.";
                QuantityText.Enabled = false;
                SumText.Enabled = true;
            }
        }

        private void Quantity_CheckedChanged(object sender, EventArgs e)
        {
            if (Quantity.Checked)
            {
                FoodPrice2.Text = "До оплати:";
                label5.Text = "грн.";
                QuantityText.Enabled = true;
                SumText.Enabled = false;
            }
        }


        private void SumText_TextChanged(object sender, EventArgs e)
        {
            if (SumText.Text == "")
            {
                return;
            }
            try
            {
                if (Convert.ToDouble(SumText.Text) < 0)
                {
                    SumText.Text = "0";
                }
            }
            catch (Exception)
            {
                SumText.Text = "";
                return;
            }
            QuantityText.Text = (Convert.ToDouble(SumText.Text) / Convert.ToDouble(textBox1.Text)).ToString();
            Price1.Text = QuantityText.Text;
        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {
            if (QuantityText.Text == "")
            {
                return;
            }
            try
            {
                if (Convert.ToDouble(QuantityText.Text) < 0)
                {
                    QuantityText.Text = "0";
                }
            }
            catch (Exception)
            {
                QuantityText.Text = "";
                return;
            }
            Price1.Text = String.Format("{0:0.00}", Convert.ToDouble(QuantityText.Text) * Convert.ToDouble(textBox1.Text));
        }

        private void Btn_Calculate_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            addEditForm.Text = "Додавання пального";
            if(addEditForm.ShowDialog() == DialogResult.OK)
            {
                names.Add(addEditForm.ProductName);
                prices.Add(addEditForm.ProductPrice);
                comboBox1.DataSource = null;
                comboBox1.DataSource = names;
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;
            if (MessageBox.Show($"Точно хочете видалити {names[ind]}", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                names.RemoveAt(ind);
                prices.RemoveAt(ind);
                comboBox1.DataSource = null;
                comboBox1.DataSource = names;
                comboBox1.SelectedIndex = 0;
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public CheckBox CheckBox_Enable { get; set; }
        public TextBox TextBox_Price { get; set; }
        public NumericUpDown Amount { get; set; }
    }
}
