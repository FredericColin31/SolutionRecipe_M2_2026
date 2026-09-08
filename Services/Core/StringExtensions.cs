using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Core
{
    public static class StringExtensions
    {
        static StringExtensions()
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }
        private static IConfiguration? Configuration;

        public static String? GetValueFor(this String key)
        {
            if (String.IsNullOrEmpty(key))
                return String.Empty;

            return Configuration?[$"appSettings:{key}"];
        }
    }
}
