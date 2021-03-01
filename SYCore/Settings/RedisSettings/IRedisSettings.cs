using System;
using System.Collections.Generic;
using System.Text;

namespace SYCore.Settings.RedisSettings
{
    public interface IRedisSettings
    {
        string RedisHostIP { get; set; }
        string RedisPort { get; set; }
        string RedisPassword { get; set; }
    }
}
