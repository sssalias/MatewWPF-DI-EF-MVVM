using Microsoft.Extensions.DependencyInjection;
using WpfApp1.Core;

namespace WpfApp1
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            var host = Bootstrapper.CreateHost();
            var app = host.Services.GetRequiredService<App>();

            app.Run();
        }
    }
}
