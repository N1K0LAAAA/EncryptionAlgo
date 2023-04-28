
using System;

class TestClass
{

    public static void Main()
    {
        LetterDicc Letter = new LetterDicc(); // LetterDicc Class
        NumberDicc Number = new NumberDicc(); // Number Dicc Class 
        EncryptToNumber Encrypt = new EncryptToNumber(); // Encrypt funktion
        Console.WriteLine("Text to be Encrypted"); // 
        string input = Console.ReadLine(); // Get input
        string inputUpper = input.ToUpper(); // all input to Upper case current ASCII code is set only to UpperCase Chars
        Letter.printDicc(); // Debug
        Number.printDicc(); // Debug
        Letter.replaceInput(inputUpper); // Replaces the Input from Chars to Ints between 32000 and 9999
        List<int> numbers = Letter.replaceInput(inputUpper); // I declare that numbers uses the chars we converted to ins with a value between 3200 - 9999
        Encrypt.encryptNumberList(numbers); // We print the Numbers here we take the Ints that we convert and multiplacte them by the next int in the list
        List<int> numbersEncrypt = Number.replaceNumberInput(numbersEncrypt); // Here is the error that i have to fix 
        Number.replaceNumberInput(numbersEncrypt);
        Console.ReadKey();
    }
}
