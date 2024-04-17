using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForJuniors.DataReaders
{
    internal abstract class DataReader
    {
        public abstract string ReadTxtData(string fileName);
    }
}
