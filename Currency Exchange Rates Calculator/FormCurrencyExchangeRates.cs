using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Currency_Exchange_Rates_Calculator
{
    public partial class FormCurrencyExchangeRates : Form
    {
        public FormCurrencyExchangeRates()
        {
            InitializeComponent();
        }

        private void FormCurrencyExchangeRates_Load(object sender, EventArgs e)
        {
            this.currencyTableAdapter.Fill(this.currencyDBDataSet.Currency);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string currentCurrency = comboBoxCurrentCurrency.Text;
            string newCurrency = comboBoxNewCurrency.Text;

            /*TRIED TO USE JSON. EMPTY rates list.
            string jsonText = File.ReadAllText("currencies.json");

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            JsonCurrency objectDeserialized = serializer.Deserialize<JsonCurrency>(jsonText);

            foreach (JsonRate item in objectDeserialized.rates)
                Debug.Write(item.code);
           */

            //RETRIEVING THE CURRENCY RATES FROM THE DATABASE
            SqlConnection connection = new SqlConnection(@"Data Source=MARIA-PC\SQLEXPRESS;Initial Catalog=CurrencyDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT CurrencyRate FROM Currency where CurrencyName = @param", connection);
            cmd.Parameters.AddWithValue("@param", currentCurrency);

            connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            double a = (double)dataReader[0];
            dataReader.Close();

            cmd = new SqlCommand("SELECT CurrencyRate FROM Currency where CurrencyName = @param", connection);
            cmd.Parameters.AddWithValue("@param", newCurrency);
            dataReader = cmd.ExecuteReader();
            dataReader.Read();

            //CALCULATING EXCHANGE RATES
            double b = (double)dataReader[0]; 
            double result = (double)(1 / a);
            result = Math.Round(result * b, 4);

            labelResult.Text = result.ToString();
            labelExchangeRate.Text = "Exchange Rate:";
        }

        private void comboBoxNewCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
            
       
    
