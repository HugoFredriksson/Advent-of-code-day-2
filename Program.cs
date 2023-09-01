using System;
using System.Linq;
int totalScore = 0;
string[] input = File.ReadAllLines("input.txt");

foreach (string inputItem in input)
{
    if (inputItem == "A Z"||inputItem == "B X" ||inputItem == "C Y") totalScore += 0;
    if (inputItem == "A X" || inputItem == "B Y" || inputItem == "C Z") totalScore += 3;
    if (inputItem == "A Y" || inputItem == "B Z" || inputItem == "C X") totalScore += 6;
    if (inputItem[2] == 'Z') totalScore += 3;
    if (inputItem[2] == 'Y') totalScore += 2; 
    if (inputItem[2] == 'X') totalScore += 1;
}
Console.WriteLine(totalScore);
