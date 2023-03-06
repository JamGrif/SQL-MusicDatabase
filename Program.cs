using System.Runtime.InteropServices;

namespace DatabaseSQLApp
{
    internal static class Program
    {
#if DEBUG
        [DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AllocConsole();
#endif

        [STAThread]
        static void Main()
        {

#if DEBUG
            // Only enable console if debug mode
            AllocConsole();
#endif

            ApplicationConfiguration.Initialize();
            Application.Run(new MusicForm());
        }
    }
}