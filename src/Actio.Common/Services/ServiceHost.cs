using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using RawRabbit;

namespace Actio.Common.Services
{
    public class ServiceHost: IServiceHost
    {
        private readonly IWebHost _webHost;

        public ServiceHost (IWebHost webHost)
        {
            _webHost = webHost;
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Run() => _webHost.Run();

        public static HostBuilder Create<TStartup>(string[] args) where TStartup : class
        {
            Console.Title = typeof(TStartup).Namespace;

            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            var webHostBuilder = WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(config)
                .UseStartup<TStartup>();

            return new HostBuilder(webHostBuilder.Build());
        }

        public abstract class BuilderBase
        {
            public abstract ServiceHost Build();
        }

        public class HostBuilder: BuilderBase
        {
            private readonly IWebHost _webHost;

            private IBusClient _bus;

            public HostBuilder(IWebHost webHost)
            {
                _webHost = webHost;
            }

            public BusBuilder UseRabbitMq()
            {

            }

            public override ServiceHost Build()
            {
                throw new NotImplementedException();
            }
        }

    }

}