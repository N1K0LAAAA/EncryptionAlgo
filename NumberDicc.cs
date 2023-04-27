using System;
class NumberDicc
{
private Dictionary<int, char> dictN;

   public NumberDicc()
    {
    
     dictN = new Dictionary<int, char>();   
     Random rnd = new Random(); 
     for (int i = 48; i <= 57; i++){
        dictN.Add(((int)i), (char)rnd.Next(49,57));
     }


    }
    public void printDicc(){
      foreach(KeyValuePair<int,char> ele in dictN){
         Console.WriteLine(ele.Key + " " + ele.Value);
      }
    }
}
 /*  public List<int> replaceInput(string inputUpper){
         char[] chars = inputUpper.ToCharArray();
          List<int> numbers = new List<int>();
         for (int i = 0; i < chars.Length; i++){
            if (dict.ContainsKey(chars[i])){
               numbers.Add(dict[chars[i]]);
            }
        }
        for(int i = 0; i < numbers.Count; i++){
         Console.WriteLine(numbers[i]);
        }
        return numbers;
   }
}
 */