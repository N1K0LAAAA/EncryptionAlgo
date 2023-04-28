using System;
class NumberDicc
{
private Dictionary<int, char> dictN; // We use a constructor and make a private Dictionary 

   public NumberDicc() // Here we make a Dictionary that gives the numbers 0 , 9 a random Char everytime we run it 
    {
    
     dictN = new Dictionary<int, char>();   // Dictionary with int and char value
     Random rnd = new Random(); // Random Function
     for (int i = 0; i <= 9; i++){ // for every int
        dictN.Add(((int)i), (char)rnd.Next(65,90)); // we add every int and add a random Char
     }

    }

    public void printDicc(){ // Printing the Dictionary Debugg pourpose 
      foreach(KeyValuePair<int,char> ele in dictN){ // Foreach KeyValue Pair in our Dict 
         Console.WriteLine(ele.Key + " " + ele.Value); // We print it 
      }
    }

  public List<char> replaceNumberInput(List<int>numbersEncrypt ){ // Here we take the Numbers that are multiplacted and give them a char
            List<char> final = new List<char>(); // New char list 
            for (int i = 0; i < numbersEncrypt.Count; i++){ // for every Number that we multiplicated 
            if (dictN.ContainsKey(numbersEncrypt[i])){ // we check if contains the Key (0-9)
               final.Add(dictN[numbersEncrypt[i]]); // and if does we add it to our Dictionary
            }
         }
        
        for(int i = 0; i < final.Count; i++){ // For every Key Pair
         Console.WriteLine(final[i]); // we print it 
        }
        return final; // And we run it 

       }
  }

