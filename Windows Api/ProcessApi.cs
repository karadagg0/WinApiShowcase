namespace WindowsApi.Windows_Api
{
    internal class ProcessApi
    {
        public static string GetRunningProcesses()
        {
            var processes = System.Diagnostics.Process.GetProcesses();
            var result = string.Empty;
            foreach (var process in processes)
            {
                result += $"{process.ProcessName}\n";
            }
            return result;
        }
    }
}
