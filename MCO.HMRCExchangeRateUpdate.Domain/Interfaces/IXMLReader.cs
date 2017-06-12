namespace MCO.HMRCExchangeRateUpdate.Domain.Interfaces
{
    using System.Xml.Linq;

    public interface IXMLReader
    {
        XDocument Return_HMRCExchangeRates_ToXDocument(string _xmlUrl);
    }
}
