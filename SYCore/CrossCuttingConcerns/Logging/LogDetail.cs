using System;
using System.Collections.Generic;

namespace SYCore.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
        public DateTime DateTime { get; set; }
    }
}