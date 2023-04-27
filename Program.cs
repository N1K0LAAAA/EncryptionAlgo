
using System;
class TestClass
{
   public static void Main()
    {
        LetterDicc Letter = new LetterDicc();
        Console.WriteLine("Text to be Encrypted");
        string input = Console.ReadLine();
        string inputUpper = input.ToUpper();
        Letter.printDicc();
        Letter.replaceInput(inputUpper);
        Console.ReadKey();
    }
}