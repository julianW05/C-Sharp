namespace Spotify_App
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Database.Instance().server = "Localhost";
            Database.Instance().databaseName = "c_sharp_spotify_opdracht";
            Database.Instance().userName = "root";
            Database.Instance().password = "admin";
            Database.Instance().IsConnect();
        }
    }
}