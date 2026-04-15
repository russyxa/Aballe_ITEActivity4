using Aballe_ITEActivity4;

namespace Aballe_ITEActivity4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm()); // ← changed from Form1
        }
    }
}