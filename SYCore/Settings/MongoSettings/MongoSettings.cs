using System;
using System.Collections.Generic;
using System.Text;

namespace SYCore.Settings.MongoSettings
{
    public class MongoSettings : IMongoSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
