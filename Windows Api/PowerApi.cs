using System.Runtime.InteropServices;

namespace WindowsApi.Windows_Api
{
    internal class PowerApi
    {
        [DllImport("powrprof.dll", SetLastError = true)]
        public static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        public static void SuspendSystem()
        {
            Console.WriteLine("Suspending system...");
            SetSuspendState(false, true, false);
        }
    }
}
