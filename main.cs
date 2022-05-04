// Created by: Mark Palfi
// Created on: Mar 2022
//
// This program does math 

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double lineA;
        double lineB;
        double lineC;


        Console.WriteLine("This program calculates the the type of triangle.");
        Console.WriteLine("");
        
        // input
        Console.Write("Enter the first side: ");
        lineA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second side: ");
        lineB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter third side: ");
        lineC = Convert.ToDouble(Console.ReadLine());
        
        // process
        if ((lineA == lineB) && (lineA == lineC) && (lineB == lineC)) {
    Console.WriteLine("It's equilateral");
  }  else if (lineA != lineB && lineA != lineC && lineB != lineC) {
    Console.WriteLine("It's scalene");
  }  else if (lineA == lineB && lineA != lineC && lineB != lineC) {
    Console.WriteLine("It's isosceles");
  }  else if (lineA != lineB && lineA == lineC && lineB != lineC) {
    Console.WriteLine("It's isosceles");
  }  else if (lineA != lineB && lineA != lineC && lineB == lineC) {
    Console.WriteLine("It's isosceles");
  }
}