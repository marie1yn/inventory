using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;
using inventory.Infrastructure.Repositories;
using inventory.Application.Interfaces;
using inventory.Application.Services;
using inventory.Infrastructure.Services;
using inventory.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace inventory
{
    internal static class Program
    {
        private static ServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            var configuration = LoadConfiguration();

            var services = new ServiceCollection();
            ConfigureServices(services, configuration);
            serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetRequiredService<Form1>();
            System.Windows.Forms.Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<Form1>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddSingleton(configuration);

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));
        }

        private static IConfiguration LoadConfiguration()
        {
            var basePath = AppContext.BaseDirectory;

            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath) // Ensures the correct directory is used
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
