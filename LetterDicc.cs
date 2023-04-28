using System;
class LetterDicc
{
    private Dictionary<char, int> dict;

    // Here We Create a Dictionary , The Key is every letter of the alphabet and the Value a number between 3200 and 9999
    public LetterDicc()
    {

        dict = new Dictionary<char, int>();
        Random rnd = new Random();
        for (int i = 65; i <= 90; i++)
        {
            dict.Add(((char)i), rnd.Next(3200, 9999));
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
}
