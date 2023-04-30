using System;
using Newtonsoft.Json;
class NumberDicc
{
    private Dictionary<int, char> dictN;

    // Here We Create a Dictionary , The Key is 0 till 9 and the Value are random Letters of the Alphabet

public NumberDicc()
{
    dictN = new Dictionary<int, char>();
    Random rnd = new Random();
    HashSet<char> addedChars = new HashSet<char>();

    for (int i = 0; i <= 9; i++)
    {
        char c;
        do {
            c = (char)rnd.Next(65, 90);
        } while (addedChars.Contains(c));

        addedChars.Add(c);
        dictN.Add(i, c);
    }
}


   //Debugging Pourpose 

    public void printDicc()
    {
        foreach (KeyValuePair<int, char> ele in dictN)
        {
            Console.WriteLine(ele.Key + " " + ele.Value);
        }
    }

   // Here we take numbersEncrypt convert them to a string and after converting them to a string
   // we convert them to a char array and than to int array and at the end we give every int a char 
    public string replaceNumberInput(List<int> numbersEncrypt)
    {
        List<char> final = new List<char>();
        List<int> toSingleDigits = new List<int>();
        string toSingleDigitsString = "";
        for (int i = 0; i < numbersEncrypt.Count; i++)
        {
            toSingleDigitsString += numbersEncrypt[i];
        }
        char[] toSingleDigitsChar = toSingleDigitsString.ToCharArray();
        int[] toSingleDigitsInt = new int[toSingleDigitsChar.Length];
        for (int i = 0; i < toSingleDigitsChar.Length; i++)
        {
            toSingleDigitsInt[i] = Convert.ToInt32(toSingleDigitsChar[i].ToString());
        }
        for (int i = 0; i < toSingleDigitsInt.Length; i++)
        {
            if (dictN.ContainsKey((toSingleDigitsInt[i])))
            {
                final.Add(dictN[(toSingleDigitsInt[i])]);
            }
        }
         string encryptText = "";
        for (int i = 0; i < final.Count; i++)
        {
            encryptText += final[i];
            
        }
        return encryptText;
    }

    public string exportDictionary(){
        string number = JsonConvert.SerializeObject(dictN, Formatting.Indented);
        Console.WriteLine(number);
        return number;
    }
}
