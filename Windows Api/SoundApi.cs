using System.Runtime.InteropServices;

namespace WindowsApi.Windows_Api
{
    internal class SoundApi
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        public static string BeepSound()
        {
            Beep(750, 300);
            return "Beep sound played!";
        }
    }
}
