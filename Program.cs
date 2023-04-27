
using System;

class TestClass
{

    public static void Main()
    {
        LetterDicc Letter = new LetterDicc();
        NumberDicc Number = new NumberDicc();
        EncryptToNumber Encrypt = new EncryptToNumber();
        Console.WriteLine("Text to be Encrypted");
        string input = Console.ReadLine();
        string inputUpper = input.ToUpper();
        Letter.printDicc();
        Number.printDicc();
        Letter.replaceInput(inputUpper);
        List<int> numbers = Letter.replaceInput(inputUpper);
        Encrypt.encryptList(numbers);
        Console.ReadKey();
    }
}