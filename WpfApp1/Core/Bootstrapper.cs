using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WpfApp1.ViewModel;
using WpfApp1.ViewModels;

namespace WpfApp1.Core
{
    internal class Bootstrapper
    {
        public static IHost CreateHost() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddDbContext<DBContext>();
                    services.AddTransient<App>();
                    services.AddTransient<PositionViewModel>();
                    services.AddTransient<MainViewModel>();
                    services.AddTransient<MainWindow>();

                })
                .Build();
    }
}
