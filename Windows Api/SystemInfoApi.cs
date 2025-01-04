namespace WindowsApi.Windows_Api
{
    internal class SystemInfoApi
    {
        public static string GetOSVersion()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
