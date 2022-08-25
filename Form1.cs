using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace CurrenciesDB_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CurrencyDBService.CurrencyDBServiceClient dbServiceClient = new CurrencyDBService.CurrencyDBServiceClient())
            {
                var selectedDate = dateTimePicker1.Value;
                string selectedDateString = selectedDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                string selectedCurrency = (string)comboBox1.SelectedItem;

                var currencyDetailsList = dbServiceClient.getCurrenyAsync(selectedDate,selectedCurrency).Result;

                dataGridView1.DataSource = currencyDetailsList;

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("İstenilen Özelliklere Ait Veri Bulunamadı..!", "HATA");
                }
                else
                {
                    dataGridView1.Columns["Date_"].DisplayIndex = 0;
                    dataGridView1.Columns["Currency_"].DisplayIndex = 1;
                    dataGridView1.Columns["Buying_"].DisplayIndex = 2;
                    dataGridView1.Columns["Selling_"].DisplayIndex = 3;

                    dataGridView1.Columns["Date_"].HeaderText = "TARİH";
                    dataGridView1.Columns["Currency_"].HeaderText = "DÖVİZ CİNSİ";
                    dataGridView1.Columns["Buying_"].HeaderText = "DÖVİZ ALIŞ";
                    dataGridView1.Columns["Selling_"].HeaderText = "DÖVİZ SATIŞ";
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}