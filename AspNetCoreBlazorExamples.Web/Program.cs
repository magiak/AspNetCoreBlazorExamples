using Microsoft.AspNetCore.Blazor.Hosting;

namespace AspNetCoreBlazorExamples.Web
{
    public class Program
    {
        // https://medium.freecodecamp.org/how-to-create-an-application-using-blazor-and-entity-framework-core-1c1679d87c7e
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
