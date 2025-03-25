using System;
class Program{
  static bool ContinueBool=true;
  static void Main(string[] args)
  {
    Console.WriteLine("SIMPLE CALCULATOR USINNG C#");


    do{
        Console.WriteLine("1.ADDITION");
        Console.WriteLine("2.SUBTRACTION");
        Console.WriteLine("3.MULTIPLICATION");
        Console.WriteLine("4.DIVISION");
        Console.WriteLine("5.EXIT");

        Console.WriteLine();
        Console.WriteLine("ENTER YOUR OPTION");
        int option= Convert.ToInt32(Console.ReadLine());
      

        Console.WriteLine("ENTER 1ST NUMBER: ");
        double firstNumber=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ENTER 2ND NUMBER: ");
        double secondNumber=Convert.ToDouble(Console.ReadLine());

        double result=0;

        switch(option){
            case 1:
                result=additionFunction(firstNumber, secondNumber);
                Console.WriteLine("ADDITION OF " + firstNumber + " AND " +secondNumber + " IS " + result);
                break;

            case 2:
                result=subtractionFunction(firstNumber, secondNumber);
                Console.WriteLine("SUBTRACTION OF " + firstNumber + " AND " +secondNumber + " IS " + result);
                break;
            case 3:
                result=multiplicationFunction(firstNumber, secondNumber);
                Console.WriteLine(" MULTIPLICATION OF " + firstNumber + " AND " +secondNumber + " IS " + result);                
                break;
            case 4:
                result=divisionFunction(firstNumber, secondNumber);
                Console.WriteLine("DIVISION OF " + firstNumber + " AND " +secondNumber + " IS " + result);
                break; 
        }
        doyouContinueFunction();

    }while(ContinueBool);
  }
  static double additionFunction(double num1, double num2){
    return num1+num2;
  }
    static double subtractionFunction(double num1, double num2){
    return num1-num2;
  }
    static double multiplicationFunction(double num1, double num2){
    return num1*num2;
  }
    static double divisionFunction(double num1, double num2){
    return num1/num2;
  }
  static void doyouContinueFunction(){
    Console.WriteLine("DO YOU WANT TO CONTINUE(YES/NO): ");
    string Continue =Console.ReadLine().ToUpper();

    if(Continue == "YES"){
        ContinueBool=true;
    }
    else if(Continue == "NO"){
        ContinueBool=false;
    }
  }
  }
