namespace WindowsApi.Windows_Api
{
    internal class EnvironmentApi
    {
        public static string GetEnvironmentVariables()
        {
            var vars = Environment.GetEnvironmentVariables();
            var result = string.Empty;
            foreach (var key in vars.Keys)
            {
                result += $"{key}: {vars[key]}\n";
            }
            return result;
        }
    }
}
