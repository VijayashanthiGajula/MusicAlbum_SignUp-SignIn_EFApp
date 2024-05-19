using System.Configuration;

namespace MusicEFApp
{
    internal static class Program
    {
        public static MusicDBContext DbContext { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            InitializeDbContext();
            Application.Run(new Form1());
        }
        static void InitializeDbContext()
        {
           
            // Initialize your DbContext instance
            DbContext = new MusicDBContext();
        }
    }
}