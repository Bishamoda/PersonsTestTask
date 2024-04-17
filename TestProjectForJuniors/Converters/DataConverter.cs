using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectForJuniors.Models;

namespace TestProjectForJuniors.Formatters
{
    internal abstract class DataConverter
    {
        public abstract List<Person> Convert(string data);
    }
}
