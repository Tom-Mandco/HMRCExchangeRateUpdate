namespace MCO.HMRCExchangeRateUpdate.Domain.Classes
{
    using Interfaces;
    using Models;
    using Data.Interfaces;
    using Data.Models;
    using System.Collections.Generic;

    public class PerformInsert : IPerformInsert
    {
        private readonly IRepository oracleConnection;
        private readonly IDataAdapter dataAdapter;

        public PerformInsert(IRepository oracleConnection, IDataAdapter dataAdapter)
        {
            this.oracleConnection = oracleConnection;
            this.dataAdapter = dataAdapter;
        }

        public void Post_UpdatedExchangeRates_ToDb(ExchangeRates exchangeRates)
        {
            List<DB_ExchangeRate> _updatedExchangeRates = dataAdapter.Map_ExchangeRates_ToDBModelList(exchangeRates);

            oracleConnection.Post_UpdatedExchangeRates_ToDb(_updatedExchangeRates);
        }
    }
}
