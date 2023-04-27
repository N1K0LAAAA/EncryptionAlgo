using System;
class LetterDicc
{
private Dictionary<char, int> dict;

   public LetterDicc()
    {
    
     dict = new Dictionary<char, int>();   
     Random rnd = new Random(); 
     for (int i = 65; i <= 90; i++){
        dict.Add(((char)i), rnd.Next(3200,9999));
     }


    }
    public void printDicc(){
      foreach(KeyValuePair<char,int> ele in dict){
         Console.WriteLine(ele.Key + " " + ele.Value);
      }
    }
   public List<int> replaceInput(string inputUpper){
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
