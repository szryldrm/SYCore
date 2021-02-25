using System;
using System.Collections.Generic;
using System.Text;

namespace SYCore.CrossCuttingConcerns.Logging
{
    public class LogDetailWithPerformance : LogDetail
    {
        public int Interval { get; set; }
    }
}
