namespace MCO.HMRCExchangeRateUpdate.Application.Interfaces
{
    using System.Xml.Linq;
    using Domain.Models;

    public interface IDataHandler
    {
        XDocument Return_HMRCExchangeRates_ToXDocument(string _xmlUrl);
        ExchangeRates Parse_HMRCExchangeRateXML_ToModel(XDocument xmlResult);
        void Post_UpdatedExchangeRates_ToDb(ExchangeRates exchangeRates);
    }
}
