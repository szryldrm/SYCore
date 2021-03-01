using System;
using System.Collections.Generic;
using System.Text;

namespace SYCore.Settings.RedisSettings
{
    public class RedisSettings : IRedisSettings
    {
        public string RedisHostIP { get; set; }
        public string RedisPort { get; set; }
        public string RedisPassword { get; set; }

    }
}
