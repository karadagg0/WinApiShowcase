using System.Runtime.InteropServices;
using System.Text;
namespace WindowsApi.Windows_Api
{
    internal class ComputerInfoApi
    {
        [DllImport("kernel32.dll")]
        public static extern bool GetComputerName(StringBuilder sb, ref int length);

        public static string GetComputerName()
        {
            var sb = new StringBuilder(256);
            int size = sb.Capacity;
            GetComputerName(sb, ref size);
            return sb.ToString();
        }
    }
}
