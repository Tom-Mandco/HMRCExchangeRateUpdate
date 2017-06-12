namespace MCO.HMRCExchangeRateUpdate.Application.Classes
{
    using Interfaces;
    using Domain.Models;
    using Newtonsoft.Json;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Xml.Linq;

    public class App : IApp
    {
        private readonly IDataHandler dataHandler;
        private string _xmlUrl;

        public App(IDataHandler dataHandler)
        {
            this.dataHandler = dataHandler;
            this._xmlUrl = string.Format("{0}{1}.xml",
                                         ConfigurationManager.AppSettings["ExchangeRateXMLLocation"],
                                         DateTime.Now.ToString("MMyy"));
        }

        public void Run()
        {
            XDocument xmlResult = dataHandler.Return_HMRCExchangeRates_ToXDocument(_xmlUrl);

            ExchangeRates exchangeRates = dataHandler.Parse_HMRCExchangeRateXML_ToModel(xmlResult);

            WriteModels_ToFile(exchangeRates);

            dataHandler.Post_UpdatedExchangeRates_ToDb(exchangeRates);
        }

        private void WriteModels_ToFile(ExchangeRates exchangeRates)
        {
            var _jsonSerializerSettings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            string fullFilePath = string.Format("F:\\ExchangeRates.Json");

            string json = JsonConvert.SerializeObject(exchangeRates, Formatting.Indented, _jsonSerializerSettings);

            File.WriteAllText(fullFilePath, json);
        }
    }
}
