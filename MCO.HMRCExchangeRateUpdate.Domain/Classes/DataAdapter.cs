namespace MCO.HMRCExchangeRateUpdate.Domain.Classes
{
    using Interfaces;
    using Data.Models;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;

    public class DataAdapter : IDataAdapter
    {
        public List<DB_ExchangeRate> Map_ExchangeRates_ToDBModelList(ExchangeRates exchangeRates)
        {
            List<DB_ExchangeRate> result = new List<DB_ExchangeRate>();

            string[] countryCodes = ConfigurationManager.AppSettings["CountryCodesToRecord"].Split(';');

            foreach (ExchangeRate _exchangeRate in exchangeRates.Exchange_Rates)
            {
                if (countryCodes.Contains(_exchangeRate.To_Country_Code))
                {
                    DB_ExchangeRate _newExchangeRate = new DB_ExchangeRate()
                    {
                        FROM_COUNTRY_CODE = _exchangeRate.From_Country_Code,
                        FROM_CURRENCY = _exchangeRate.From_Currency_Code,
                        TO_COUNTRY_CODE = _exchangeRate.To_Country_Code,
                        TO_CURRENCY = _exchangeRate.To_Currency_Code,
                        EFFECTIVE_DATE = exchangeRates.Effective_Date,
                        EXCHANGE_RATE = _exchangeRate.Rate_of_Exchange,
                        LAST_UPDATE_USR_ID = "HMRC_Update"
                    };

                    result.Add(_newExchangeRate);
                }
            }

            return result;
        }
    }
}
