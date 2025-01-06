using CrypticWizard;
namespace PasswordGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> SpecialCharacters = new List<string>()
            {
                "!",
                "@",
                "#",
                "$",
                "%",
                "/",
                "?"
            };
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine(SpecialCharacters);
            foreach (var SpecialCharacter in SpecialCharacters)
            {
                Console.WriteLine(SpecialCharacter);
            }
        }
    }
}