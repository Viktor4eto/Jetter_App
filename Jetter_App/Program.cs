namespace Jetter_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            string source = @"LAB109PC08\SQLEXPRESS";
            string database = @"Data Source=" + source + "; Initial Catalog=Jetter; Integrated Security=True;";

            ApplicationConfiguration.Initialize();
            Application.Run(new Log_In(database));
        }
    }
}