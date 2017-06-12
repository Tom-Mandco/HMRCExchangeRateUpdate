namespace MCO.HMRCExchangeRateUpdate.Domain.Classes
{
    using System.Xml.Linq;
    using Interfaces;
    using Models;

    public class PerformLookup : IPerformLookup
    {
        private readonly IXMLParser xmlParser;
        private readonly IXMLReader xmlReader;

        public PerformLookup(IXMLParser xmlParser, IXMLReader xmlReader)
        {
            this.xmlParser = xmlParser;
            this.xmlReader = xmlReader;
        }

        public XDocument Return_HMRCExchangeRates_ToXDocument(string _xmlUrl)
        {
            return xmlReader.Return_HMRCExchangeRates_ToXDocument(_xmlUrl);
        }

        public ExchangeRates Return_HMRCExchangeRates_ToModel(XDocument xmlResult)
        {
            return xmlParser.Return_HMRCExchangeRates_ToModel(xmlResult);
        }
    }
}
