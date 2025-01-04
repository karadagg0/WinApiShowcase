using System.Runtime.InteropServices;

namespace WindowsApi.Windows_Api
{
    internal class ScreenApi
    {
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        const int SM_CXSCREEN = 0;
        const int SM_CYSCREEN = 1; 

        public static string GetScreenResolution()
        {
            int width = GetSystemMetrics(SM_CXSCREEN);
            int height = GetSystemMetrics(SM_CYSCREEN);
            return $"{width}x{height}";
        }
    }
}
