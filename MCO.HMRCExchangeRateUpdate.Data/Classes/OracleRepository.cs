namespace MCO.HMRCExchangeRateUpdate.Data.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using MandCo.Data;
    using Models;

    public class OracleRepository : OracleBase, IRepository
    {
        public OracleRepository(string connectionString)
    : base(connectionString)
        {
        }

        public void Post_UpdatedExchangeRates_ToDb(List<DB_ExchangeRate> _updatedExchangeRates)
        {
            throw new NotImplementedException();
        }
    }
}
