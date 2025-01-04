using System.Runtime.InteropServices;

namespace WindowsApi.Windows_Api
{
    internal class ClipboardApi
    {
        [DllImport("user32.dll")]
        public static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll")]
        public static extern IntPtr GetClipboardData(uint uFormat);

        [DllImport("user32.dll")]
        public static extern bool CloseClipboard();

        public static string GetClipboardText()
        {
            try
            {
                if (!OpenClipboard(IntPtr.Zero)) return "Clipboard is not accessible.";
                uint CF_TEXT = 1;
                IntPtr handle = GetClipboardData(CF_TEXT);
                CloseClipboard();
                return  Marshal.PtrToStringAnsi(handle) ?? "";
            }
            catch
            {
                return "Error accessing clipboard.";
            }
        }
    }
}
