namespace DataTransformation.Helpers
{
    public static class Converters
    {
        public static string TimestampToDate(string date)
        {
            try
            {
                string response = string.Empty;

                if (!string.IsNullOrEmpty(date))
                {
                    long timestamp = long.Parse(date);
                    response = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime.ToString("yyyy-MM-dd");
                }

                return response;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }    
}
