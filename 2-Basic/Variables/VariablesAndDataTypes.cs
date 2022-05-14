/*

int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false

*/

using System;

namespace VariablesAndDataTypes
{
  class VariablesAndDataTypes
  {
    static void Main(string[] args)
    {
      //String
      string FirstName = "Arifian";
      string LastName = "Saputra";
      Console.WriteLine(FirstName);
      Console.WriteLine("Good Morning, Mr. " + FirstName + " " + LastName);

      //Char
      char myGrade = 'B';
      Console.WriteLine(myGrade);

      //Integer
      int myNum = 20;
      int myNum2 = 40;
      Console.WriteLine(myNum);
      Console.WriteLine(myNum + myNum2);
      int Number;
      Number = 50;
      Console.WriteLine(Number);

      //Long
      long myMoney = 2000002220212212L;
      Console.WriteLine(myMoney);

      //Double
      double myDouble = 19.99D;
      Console.WriteLine(myDouble);

      //Float
      float myFloat = 2.21F;
      Console.WriteLine(myFloat);

      float f1 = 35e3F;
      double d1 = 12E4D;
      Console.WriteLine(f1);  //Scientific Notation with float
      Console.WriteLine(d1);  //Scientific Notation with double

      //Boolean
      bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);
      Console.WriteLine(isFishTasty); 

    }
  }
}