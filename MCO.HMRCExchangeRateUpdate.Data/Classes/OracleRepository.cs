namespace MCO.HMRCExchangeRateUpdate.Data.Classes
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models;
    using System.Configuration;
    using Oracle.ManagedDataAccess.Client;
    using System.Data;
    using System.Linq;

    public class OracleRepository : IRepository
    {
        private OracleConnection oracleConnection;

        public void Post_UpdatedExchangeRates_ToDb(List<DB_ExchangeRate> _updatedExchangeRates)
        {
            try
            {
                string query = SqlLoader.GetSql("Merge_ExchangeRates_ToDb");

                oracleConnection = new OracleConnection(GetConnectionString());
                oracleConnection.Open();

                using (var command = oracleConnection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    command.BindByName = true;
                    command.ArrayBindCount = _updatedExchangeRates.Count;
                    command.Parameters.Add(":fromCur", OracleDbType.Varchar2, _updatedExchangeRates.Select(c => c.FROM_CURRENCY).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":toCur", OracleDbType.Varchar2, _updatedExchangeRates.Select(c => c.TO_CURRENCY).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":effDate", OracleDbType.Date, _updatedExchangeRates.Select(c => c.EFFECTIVE_DATE).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":exchRate", OracleDbType.Decimal, _updatedExchangeRates.Select(c => c.EXCHANGE_RATE).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":usr", OracleDbType.Varchar2, _updatedExchangeRates.Select(c => c.LAST_UPDATE_USR_ID).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":usrTime", OracleDbType.Date, _updatedExchangeRates.Select(c => c.LAST_UPDATE_DATE).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":fromCountry", OracleDbType.Varchar2, _updatedExchangeRates.Select(c => c.FROM_COUNTRY_CODE).ToArray(), ParameterDirection.Input);
                    command.Parameters.Add(":toCountry", OracleDbType.Varchar2, _updatedExchangeRates.Select(c => c.TO_COUNTRY_CODE).ToArray(), ParameterDirection.Input);
                    int result = command.ExecuteNonQuery();
                    Console.WriteLine("{0} Rows successfully written to", result);
                }
            }
            catch (OracleException ex)
            {
                throw ex;
            }
            finally
            {
                oracleConnection.Close();
            }
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
        }
    }
}
