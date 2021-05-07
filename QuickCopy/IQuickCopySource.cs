using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public interface IQuickCopySource
    {

        string GetData(string key);

        void PutData(string key, string json);

    }
}
