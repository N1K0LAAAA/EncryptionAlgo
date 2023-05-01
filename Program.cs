
using System;

class TestClass
{

    public static void Main()
    {
        LetterDicc Letter = new LetterDicc(); 
        NumberDicc Number = new NumberDicc(); 
        EncryptToNumber Encrypt = new EncryptToNumber(); 
        ExportDicc ExpDicc = new ExportDicc();
        Console.WriteLine("Text to be Encrypted"); 
        string input = Console.ReadLine(); 
        string inputUpper = input.ToUpper(); 
        List<int> numbers = Letter.replaceInput(inputUpper); 
        List<int> numbersEncrypt = Encrypt.encryptNumberList(numbers); 
        string encryptedText = Number.replaceNumberInput(numbersEncrypt);
        string letter = Letter.exportDictionary();
        string number = Number.exportDictionary();
        string exportablestring = ExpDicc.exportDictionaryInString(letter,number);
        Console.WriteLine(encryptedText);
        Console.ReadKey();
    }
}


