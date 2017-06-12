namespace MCO.HMRCExchangeRateUpdate.Domain.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;
    using System.Xml.Linq;

    public class XMLParser : IXMLParser
    {
        public ExchangeRates Return_HMRCExchangeRates_ToModel(XDocument _xmlDoc)
        {
            List<ExchangeRate> resultList = new List<ExchangeRate>();

            foreach (XElement descendants in _xmlDoc.Root.Descendants("exchangeRate"))
            {
                string _countryCode = descendants.Element("countryCode").Value;
                string _currencyCode = descendants.Element("currencyCode").Value;
                decimal _exchRate = Convert.ToDecimal(descendants.Element("rateNew").Value);

                ExchangeRate newExchangeRate = new ExchangeRate()
                {
                    From_Country_Code = "GB",
                    From_Currency_Code = "GBP",
                    To_Country_Code = _countryCode,
                    To_Currency_Code = _currencyCode,
                    Rate_of_Exchange = _exchRate,
                };

                resultList.Add(newExchangeRate);
            }

            ExchangeRates result = new ExchangeRates()
            {
                Exchange_Rates = resultList,
                Effective_Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            };

            return result;
        }
    }
}
