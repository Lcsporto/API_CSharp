using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Windows.Forms;


namespace FrontConFin
{
    internal static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            FrmLogin form = new FrmLogin(); //Aqui é a configuração para abrir a tela de Login antes do Form Principal
            form.ShowDialog();
            Application.Run(new FrmPrincipal());
        }
    }
}