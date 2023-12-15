// See https://aka.ms/new-console-template for more information
using PersonInfo;



string information = "maede , tehran , 22;maryam , tehran , 30;helia , shiraz , 21;yasmin , tabriz , 20";

PersonInformation personInfo = new PersonInformation();

List<string> result = personInfo.GetEachPersonInfo(personInfo.GetInfo(information));
var res = result.ToArray();

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}

var personCount = personInfo.GetInfo(information);

int sumAge = personInfo.CalculateSumAge(result);
//Console.WriteLine(sumAge);

int avgAge = personInfo.CalculateAvgAge(sumAge, personCount.Count());

Console.WriteLine($"{avgAge}");

Console.ReadKey();


