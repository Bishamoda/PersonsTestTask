using TestProjectForJuniors.DataReaders;
using TestProjectForJuniors.Formatters;
using TestProjectForJuniors.Models;

string fileName = "PersonsInformation.txt";
var reader = new TxtFileReader();
string data = reader.ReadTxtData(fileName);

var converter = new PersonsConverter();
var persons = converter.Convert(data);
var tempList = SortPersonsList(persons);

foreach (var person in tempList)
{
    Console.WriteLine(string.Format("{0} {1} {2}", person.Name, person.Age, person.Score));
}

static List<Person> SortPersonsList(List<Person> persons)
{
    var personsCount = persons.Count;
    var sumScore = persons.Sum(x => x.Score);
    var middleValue = Convert.ToDecimal(sumScore / personsCount);
    persons.RemoveAll(p => Convert.ToDecimal(p.Score) <= middleValue);
    return persons.OrderBy(x => x.Age).ToList();
}
