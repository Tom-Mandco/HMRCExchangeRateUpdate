namespace MCO.HMRCExchangeRateUpdate.Application
{
    using Interfaces;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            CompositionRoot.Wire(new ApplicationModule());

            var app = CompositionRoot.Resolve<IApp>();

            app.Run();

            Console.Read();
        }
    }
}
