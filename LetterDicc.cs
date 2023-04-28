using System;
class LetterDicc
{
private Dictionary<char, int> dict; // we construct a private Dictionary that has Chars as Key and Ints as value

   public LetterDicc() // Function that generates a random number for every letter of the alphabet
    {
    
     dict = new Dictionary<char, int>();   // Dictionary char Key int Value
     Random rnd = new Random();  // Random function
     for (int i = 65; i <= 90; i++){ // We loop through the ASCII values that are a - z
        dict.Add(((char)i), rnd.Next(3200,9999)); // Here we add the chars and a random number to them
     }


    }
    public void printDicc(){ // printing an array 
      foreach(KeyValuePair<char,int> ele in dict){ // foreach Pair of Key and Value
         Console.WriteLine(ele.Key + " " + ele.Value); // We print it this is not very importnat only used to see if it works properly 
      }
    }
    
   public List<int> replaceInput(string inputUpper){ // here we take the input string from Program.Cs
         char[] chars = inputUpper.ToCharArray(); // Convert the string into a Chararray
          List<int> numbers = new List<int>(); // We make a new list were we can add the values of the specif chars that a
         for (int i = 0; i < chars.Length; i++){ // for every char in the char array
            if (dict.ContainsKey(chars[i])){ // we check if it exists in our Dictionary 
               numbers.Add(dict[chars[i]]); // and if it does we Add it to our Dictionary
            }
        }
        for(int i = 0; i < numbers.Count; i++){ // Looping through our number list
         Console.WriteLine(numbers[i]); // Printing every value in our list
        }
        return numbers; // returning it 
   }
}
