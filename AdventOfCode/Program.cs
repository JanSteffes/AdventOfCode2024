using AdventOfCode;
using System.Text.RegularExpressions;


var inputValues = Inputs.InputValues;
const string numberRegex = "^(\\d+)\\s+(\\d+)$";
var regexToMatch = new Regex(numberRegex);

var allValues = inputValues.Split(Environment.NewLine)
    .Select(x => regexToMatch.Matches(x))
    .Select(s => (FirstValue: int.Parse(s[0].Groups[1].Value), SecondValue: int.Parse(s[0].Groups[2].Value))).ToList();
var firstList = allValues.Select(s => s.FirstValue).ToList();
var secondList = allValues.Select(s => s.SecondValue).ToList();

firstList.Sort();
secondList.Sort();

var distance = 0;
for (var i = 0; i < firstList.Count; i++)
{
    var firstValue = firstList[i];
    var secondValue = secondList[i];
    distance += Math.Abs(firstValue - secondValue);
}

Console.WriteLine("Distance: {0}", distance);