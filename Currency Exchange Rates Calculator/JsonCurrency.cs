using System.Collections.Generic;

namespace Currency_Exchange_Rates_Calculator
{
    public class JsonRate
    {
        public string code { get; set; }
        public double rate { get; set; }
    }

    class JsonCurrency
    {
         public string Base { get; set; }
         public string Date { get; set; }
         public List<JsonRate> rates { get; set; }
    }
}
