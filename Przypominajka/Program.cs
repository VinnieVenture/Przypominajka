using System;
using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Przypominajka.Core.Serialization;

namespace ChromelyAngular
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            XML_Read_Write s = new XML_Read_Write();
            //s.WriteData(new Przypominajka.Core.Models.AlarmsDTO()) ;
            s.ReadData();

            var config = DefaultConfiguration.CreateForRuntimePlatform();
            config.StartUrl = "local://dist/index.html";
            config.WindowOptions.Title = "Przypominajka";
            config.WindowOptions.WindowFrameless = true;
            config.WindowOptions.StartCentered = false;
            config.WindowOptions.Size = new WindowSize(500, 800);
            config.WindowOptions.Position = new WindowPosition(1350, 200);

            AppBuilder
                .Create()
                .UseConfig<DefaultConfiguration>(config)
                .UseApp<DemoApp>()
                .Build()
                .Run(args);
        }
    }

    public class DemoApp : ChromelyBasicApp
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
            services.AddLogging(configure => configure.AddConsole());
            services.AddLogging(configure => configure.AddFile("Logs/serilog-{Date}.txt"));

            RegisterControllerAssembly(services, typeof(DemoApp).Assembly);
        }
    }
}