namespace AdventureWindowsForms
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
            string playerName = "User"; // Define or retrieve the player name here

            MainMenuForm mainMenu = new MainMenuForm(); // Create MainMenuForm
            MainGameForm mainGame = new MainGameForm("YourSelectedFileName", playerName, mainMenu, showWelcomeMessage: false);
            Application.Run(mainMenu);
        }
    }
}