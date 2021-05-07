using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public class QuickCopyData
    {

        public QuickCopyData()
        {
            Categories = new Dictionary<Guid, Category>();
        }

        public DateTime LastModifiedTime { get; set; }

        public Dictionary<Guid, Category> Categories { get; set; }

    }
}
