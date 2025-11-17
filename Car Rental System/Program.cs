using CarRentalSystem.Generic.Repositories;
using CarRentalSystem.Main;
using CarRentalSystem.Services;
using CarRentalSystem.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarRentalSystem
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();

            services.AddScoped<RentalCarContext>();
            services.AddScoped<DbContext>(sp => sp.GetRequiredService<RentalCarContext>());
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<CarService>();
            services.AddTransient<ClientService>();
            services.AddTransient<OrderService>();

            services.AddSingleton<IFormFactory, FormFactory>();

            services.AddTransient<ClientForm>();
            services.AddTransient<AdminForm>();
            services.AddTransient<ModifyCarForm>();
            services.AddTransient<PaymentForm>();

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<ClientForm>());
        }
    }
}