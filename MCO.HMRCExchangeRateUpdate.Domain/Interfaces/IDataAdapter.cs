namespace MCO.HMRCExchangeRateUpdate.Domain.Interfaces
{
    using System.Collections.Generic;
    using Data.Models;
    using Models;

    public interface IDataAdapter
    {
        List<DB_ExchangeRate> Map_ExchangeRates_ToDBModelList(ExchangeRates exchangeRates);
    }
}
