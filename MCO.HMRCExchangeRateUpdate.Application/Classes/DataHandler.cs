namespace MCO.HMRCExchangeRateUpdate.Application.Classes
{
    using System.Xml.Linq;
    using Interfaces;
    using Domain.Models;
    using Domain.Interfaces;

    public class DataHandler : IDataHandler
    {
        private readonly IPerformLookup performLookup;
        private readonly IPerformInsert performInsert;

        public DataHandler(IPerformLookup performLookup, IPerformInsert performInsert)
        {
            this.performLookup = performLookup;
            this.performInsert = performInsert;
        }

        public ExchangeRates Parse_HMRCExchangeRateXML_ToModel(XDocument xmlResult)
        {
            ExchangeRates result = performLookup.Return_HMRCExchangeRates_ToModel(xmlResult);

            return result;
        }

        public XDocument Return_HMRCExchangeRates_ToXDocument(string _xmlUrl)
        {
            XDocument result = performLookup.Return_HMRCExchangeRates_ToXDocument(_xmlUrl);

            return result;
        }

        public void Post_UpdatedExchangeRates_ToDb(ExchangeRates exchangeRates)
        {
            performInsert.Post_UpdatedExchangeRates_ToDb(exchangeRates);
        }
    }
}
