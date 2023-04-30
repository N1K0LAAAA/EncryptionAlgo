using System;
using Newtonsoft.Json;
class LetterDicc
{
    private Dictionary<char, int> dict;

    // Here We Create a Dictionary , The Key is every letter of the alphabet and the Value a number between 3200 and 9999
public LetterDicc()
{
    dict = new Dictionary<char, int>();
    Random rnd = new Random();
    HashSet<int> addedInts = new HashSet<int>();

    for (int i = 65; i <= 90; i++)
    {
        int n;
        do {
            n = rnd.Next(3200, 9999);
        } while (addedInts.Contains(n));

        addedInts.Add(n);
        dict.Add((char)i, n);
    }
}
    
    // This  was just used for Debugging
    public void printDicc()
    {
        foreach (KeyValuePair<char, int> ele in dict)
        {
            Console.WriteLine(ele.Key + " " + ele.Value);
        }
    }
   // Here we take the input and check if it cotains the chars and if it does we add the random number and we get the List numbers at the end
    public List<int> replaceInput(string inputUpper)
    {
        char[] chars = inputUpper.ToCharArray();
        List<int> numbers = new List<int>();
        for (int i = 0; i < chars.Length; i++)
        {
            if (dict.ContainsKey(chars[i]))
            {
                numbers.Add(dict[chars[i]]);
            }
        }

        return numbers;
    }
        public string exportDictionary(){
        string letter = JsonConvert.SerializeObject(dict, Formatting.Indented);
        Console.WriteLine(letter);
        return letter;
    }
}
