using System.Xml.Linq;
using MCO.HMRCExchangeRateUpdate.Domain.Models;

namespace MCO.HMRCExchangeRateUpdate.Domain.Interfaces
{
    public interface IPerformLookup
    {
        ExchangeRates Return_HMRCExchangeRates_ToModel(XDocument xmlResult);
        XDocument Return_HMRCExchangeRates_ToXDocument(string _xmlUrl);
    }
}
