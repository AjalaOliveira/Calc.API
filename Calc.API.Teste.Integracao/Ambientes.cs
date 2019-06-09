using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;

namespace Calc.API.Teste.Integracao
{
    public class Ambiente
    {
        public static TestServer Server;
        public static HttpClient Client;

        public static void CreateServer()
        {
            Server = new TestServer(
                    new WebHostBuilder()
                        .UseEnvironment("Development")
                        .UseUrls("http://localhost:44385")
                        .UseStartup<StartUpTests>()
                );

            Client = Server.CreateClient();
        }
    }
}
