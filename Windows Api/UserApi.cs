using System.Runtime.InteropServices;
using System.Text;

namespace WindowsApi.Windows_Api
{
    internal class UserApi
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool GetUserName(StringBuilder sb, ref int length);

        public static string GetCurrentUserName()
        {
            var sb = new StringBuilder(256);
            int size = sb.Capacity;
            GetUserName(sb, ref size);
            return sb.ToString();
        }
    }
}
