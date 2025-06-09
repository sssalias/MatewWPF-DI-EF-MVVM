using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WpfApp1.ViewModels;
using WpfApp1.Views;

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
                    services.AddTransient<PositionsView>();
                    services.AddTransient<StaffViewModel>();
                    services.AddTransient<StaffsView>();
                    services.AddTransient<ProductTypeViewModel>();
                    services.AddTransient<ProductTypesView>();
                    services.AddTransient<MainWindow>();

                })
                .Build();
    }
}
