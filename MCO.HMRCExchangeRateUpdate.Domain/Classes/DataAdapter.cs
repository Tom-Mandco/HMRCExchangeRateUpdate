namespace MCO.HMRCExchangeRateUpdate.Domain.Classes
{
    using Interfaces;
    using Data.Models;
    using Models;
    using System;
    using System.Collections.Generic;

    public class DataAdapter : IDataAdapter
    {
        public List<DB_ExchangeRate> Map_ExchangeRates_ToDBModelList(ExchangeRates exchangeRates)
        {
            List<DB_ExchangeRate> result = new List<DB_ExchangeRate>();


            return result;
        }
    }
}
