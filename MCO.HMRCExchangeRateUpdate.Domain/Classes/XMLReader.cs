namespace MCO.HMRCExchangeRateUpdate.Domain.Classes
{
    using Interfaces;
    using System.Xml.Linq;

    public class XMLReader : IXMLReader
    {
        public XDocument Return_HMRCExchangeRates_ToXDocument(string _xmlUrl)
        {
            XDocument result = XDocument.Load(_xmlUrl);

            return result;
        }
    }
}
