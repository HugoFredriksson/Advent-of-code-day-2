using System;
using System.Linq;
int totalScore = 0;
string[] input = File.ReadAllLines("input.txt");

foreach (string inputItem in input)
{
    //Påse
    if (inputItem == "A Z" || inputItem == "C X" || inputItem == "B Y") totalScore += 2;
    //Sten
    if (inputItem == "B X" || inputItem == "A Y" || inputItem == "C Z") totalScore += 1;
    //Sax
    if (inputItem == "C Y" || inputItem == "B Z" || inputItem == "A X") totalScore += 3;
    if (inputItem[2] == 'Z') totalScore += 6;
    if (inputItem[2] == 'Y') totalScore += 3;
    if (inputItem[2] == 'X') totalScore += 0;
}
Console.WriteLine(totalScore);
