using System;
using System.Collections.Generic;
using System.Text;

namespace SYCore.Entities
{
    public abstract class AuditableDocument : BaseDocument
    {
        protected AuditableDocument()
        {
            ModifiedDate = DateTime.Now;
        }

        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
