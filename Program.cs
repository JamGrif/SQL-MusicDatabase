using System.Runtime.InteropServices;

namespace DatabaseSQLApp
{

    

    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            AllocConsole();

            ApplicationConfiguration.Initialize();
            Application.Run(new MusicForm());
        }
    }
}