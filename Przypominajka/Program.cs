using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przypominajka
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create a configuration with OS-specific defaults
            var config = DefaultConfiguration.CreateForRuntimePlatform();

            // your configuration
            config.StartUrl = $"D:\\Amadeusz\\IT\\Przypominajka\\Przypominajka.Angular\\ClientApp\\dist\\index.html";
            config.WindowOptions.Title = "Przypominajka";
            config.WindowOptions.WindowFrameless = true;
            config.WindowOptions.StartCentered = false;
            config.WindowOptions.Size = new WindowSize(500, 800);
            config.WindowOptions.Position = new WindowPosition(1350, 200);
            //..

            // application builder
            AppBuilder
            .Create()
            .UseApp<DemoChromelyApp>()
            .UseConfig<IChromelyConfiguration>(config)
            .Build()
            .Run(args);
        }
    }

    public class DemoChromelyApp : ChromelyBasicApp
    {
        //public override void ConfigureServices(IServiceCollection services)
        //{
        //    base.ConfigureServices(container);
        //    // other service configuration can be placed here
        //}
    }
}
