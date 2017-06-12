using System.Collections.Generic;
using MCO.HMRCExchangeRateUpdate.Data.Models;

namespace MCO.HMRCExchangeRateUpdate.Data.Interfaces
{
    public interface IRepository
    {
        void Post_UpdatedExchangeRates_ToDb(List<DB_ExchangeRate> _updatedExchangeRates);
    }
}
