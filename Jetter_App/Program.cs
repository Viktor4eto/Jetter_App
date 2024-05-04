namespace Jetter_App
{
    internal static class Program
    {
        private static string source = @"(localdb)\local";
        private static string database = @"Data Source=" + source + "; Initial Catalog=Jetter; Integrated Security=True;";

        public static string getDatabase()
        {
            return database;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            
            ApplicationConfiguration.Initialize();
            Application.Run(new Log_In());
        }
    }
}