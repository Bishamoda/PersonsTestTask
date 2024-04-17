using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectForJuniors.Models;

namespace TestProjectForJuniors.Formatters
{
    internal class PersonsConverter : DataConverter
    {
        private List<Person> _persons = new List<Person>();
        public override List<Person> Convert(string data)
        {
            if (data == null)
            {
                throw new NullReferenceException("Cannot get data, because it is not defined");
            }

            var partsLines = data.Split('\n');
            if (partsLines.Length > 0)
            {
                string[] partsLine;
                for (int i = 0; i < partsLines.Length; i++)
                {
                    partsLine = partsLines[i].Split(' ');
                    _persons.Add(new Person
                    {
                        Name = string.Format("{0} {1} {2}", partsLine[0], partsLine[1], partsLine[2]),
                        Age = System.Convert.ToInt32(partsLine[3]),
                        Score = System.Convert.ToDouble(partsLine[4].Replace('.', ',').TrimEnd('\r'))
                    });
                }
            }

            return _persons;
        }
    }
}
