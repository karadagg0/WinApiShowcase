using System.Runtime.InteropServices;

namespace WindowsApi.Windows_Api
{
    internal class MouseApi
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public struct POINT
        {
            public int X;
            public int Y;
        }

        public static string GetMousePosition()
        {
            if (GetCursorPos(out POINT point))
            {
                return $"X: {point.X}, Y: {point.Y}";
            }
            return "Unable to get mouse position.";
        }
    }
}
