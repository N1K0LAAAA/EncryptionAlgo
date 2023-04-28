
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
        List<int> numbers = Letter.replaceInput(inputUpper); 
        List<int> numbersEncrypt = Encrypt.encryptNumberList(numbers); 
        string encryptedText = Number.replaceNumberInput(numbersEncrypt);
        Console.WriteLine(encryptedText);
        Console.ReadKey();
    }
}


