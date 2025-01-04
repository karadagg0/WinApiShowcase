using WindowsApi.Windows_Api;

namespace WindowsApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Screen Resolution: " + ScreenApi.GetScreenResolution());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Memory Status: " + MemoryApi.GetAvailableMemory());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Current User: " + UserApi.GetCurrentUserName());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("OS Version: " + SystemInfoApi.GetOSVersion());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Clipboard Text: " + ClipboardApi.GetClipboardText());
            Console.WriteLine("-----------------------------------------------");

            // PowerApi.SuspendSystem();
            Console.WriteLine("Computer Name: " + ComputerInfoApi.GetComputerName());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Sound Beep Test: " + SoundApi.BeepSound());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Environment Variables: " + EnvironmentApi.GetEnvironmentVariables());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Process List:\n" + ProcessApi.GetRunningProcesses());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Mouse Position: " + MouseApi.GetMousePosition());
            Console.WriteLine("-----------------------------------------------");

            Console.ReadKey();
        }
    }
}