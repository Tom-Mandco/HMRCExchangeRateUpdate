namespace MCO.HMRCExchangeRateUpdate.Domain.Models
{
    public class ExchangeRate
    {
        public string From_Country_Code { get; set; }
        public string From_Currency_Code { get; set; }

        public string To_Country_Code { get; set; }
        public string To_Currency_Code { get; set; }

        public decimal Rate_of_Exchange { get; set; }
    }
}
