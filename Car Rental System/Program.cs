using Car_Rental_System.Models;
using Car_Rental_System.Views;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Car_Rental_System
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
            Application.Run(new ModifyCarForm());
        }
    }
}