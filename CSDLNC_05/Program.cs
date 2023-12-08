using CSDLNC_05.View.Login;

namespace CSDLNC_05
{
    internal static class Program
    {
        public static int currentUserId;
        public static string currentUserRole;
        public static List<Form> previousForm = new List<Form> { };

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UI_Login());
        }
    }
}