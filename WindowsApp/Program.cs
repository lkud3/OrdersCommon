using Lib.Common.System;            // for CMSSQLLocalDBInstanceLauncher
using Orders.Common;       // for CSettings

namespace WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Launch the local DB Instance
            CMSSQLLocalDBInstanceLauncher.Launch(CSettings.Instance.DBInstanceName);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CFormMain());
        }


    }
}