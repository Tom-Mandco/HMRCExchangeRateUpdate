namespace MCO.HMRCExchangeRateUpdate.Application
{
    using Interfaces;

    class HMRCExchangeRateUpdate
    {
        static void Main(string[] args)
        {
            CompositionRoot.Wire(new ApplicationModule());

            var app = CompositionRoot.Resolve<IApp>();

            app.Run();
        }
    }
}
