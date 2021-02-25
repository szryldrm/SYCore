using System;
using System.Collections.Generic;
using System.Text;

namespace SYCore.Settings.MongoSettings
{
    public interface IMongoSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
