namespace MCO.HMRCExchangeRateUpdate.Domain.Models
{
    using System;
    using System.Collections.Generic;

    public class ExchangeRates
    {
        public IEnumerable<ExchangeRate> Exchange_Rates { get; set; }

        public DateTime Effective_Date { get; set; }
    }
}
