namespace MCO.HMRCExchangeRateUpdate.Domain.Interfaces
{
    using Models;
    using System.Xml.Linq;

    public interface IXMLParser
    {
        ExchangeRates Return_HMRCExchangeRates_ToModel(XDocument _xmlDoc);
    }
}
