using System;
using System.IO;
using System.Text.Json;

namespace TMA.TestAnalyst.Stage2.Support
{
    /// <summary>
    /// Loads run configuration from appsettings.json (copied to the output folder).
    /// </summary>
    public class TestSettings
    {
        public string BaseUrl { get; set; } = "https://www.saucedemo.com";
        public string Browser { get; set; } = "chrome";
        public bool Headless { get; set; } = false;
        public int DefaultTimeoutSeconds { get; set; } = 10;

        private static TestSettings _current;
        public static TestSettings Current => _current ??= Load();

        private static TestSettings Load()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            if (!File.Exists(path))
            {
                return new TestSettings();
            }

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<TestSettings>(
                       json,
                       new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                   ?? new TestSettings();
        }
    }
}
