using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForJuniors.DataReaders
{
    internal class TxtFileReader : DataReader
    {
        private string _data;
        public override string ReadTxtData(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(fileName, "The value should not be null or empty");
            }
            
            using (StreamReader sr = new StreamReader(fileName))
            {
                _data = sr.ReadToEnd();
            }
            return _data;
        }
    }
}
