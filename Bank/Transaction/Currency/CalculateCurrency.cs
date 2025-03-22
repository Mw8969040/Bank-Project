using BusinessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class CalculateCurrency : Form
    {
        public CalculateCurrency()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void FillAllCombo()
        {

            DataTable Dt = ClsCurrency.ListCurrency();

            foreach (DataRow row in Dt.Rows)
            {
                  comboBox1.Items.Add(row["Currency_Code"]);
                  comboBox2.Items.Add(row["Currency_Code"]);
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private float ConverToUSD(decimal Amount , string CurrencyTo)
        {
            return (float)(Amount / (decimal)ClsCurrency.GetRate(CurrencyTo));

        }

        private float ConverToOtherCurrency(float Amount , string CurrencyFrom)
        {
            return (Amount*ClsCurrency.GetRate(CurrencyFrom));
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            
            txtResult.Text= ConverToOtherCurrency(ConverToUSD(NumericAmount.Value, comboBox1.Text), comboBox2.Text).ToString()+" "+comboBox2.Text;
        }

        private void CalculateCurrency_Load(object sender, EventArgs e)
        {
            FillAllCombo();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            txtResult.Text = "Result";
            NumericAmount.Value = NumericAmount.Minimum;
        }
    }
}
