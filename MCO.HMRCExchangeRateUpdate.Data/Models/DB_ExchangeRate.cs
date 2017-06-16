namespace MCO.HMRCExchangeRateUpdate.Data.Models
{
    using System;

    public class DB_ExchangeRate
    {
        public DB_ExchangeRate()
        {
            this.LAST_UPDATE_DATE = DateTime.Now; 
        }

        public string FROM_CURRENCY { get; set; }
        public string FROM_COUNTRY_CODE { get; set; }
        public string TO_CURRENCY { get; set; }
        public string TO_COUNTRY_CODE { get; set; }
        public string LAST_UPDATE_USR_ID { get; set; }

        public decimal EXCHANGE_RATE { get; set; }

        public DateTime EFFECTIVE_DATE { get; set; }
        public DateTime LAST_UPDATE_DATE { get; private set; }
    }
}
