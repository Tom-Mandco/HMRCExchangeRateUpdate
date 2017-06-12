namespace MCO.HMRCExchangeRateUpdate.Domain.Interfaces
{
    using Models;

    public interface IPerformInsert
    {
        void Post_UpdatedExchangeRates_ToDb(ExchangeRates exchangeRates);
    }
}
