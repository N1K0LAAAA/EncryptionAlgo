using System;
class NumberDicc
{
private Dictionary<int, char> dictN;

   public NumberDicc()
    {
    
     dictN = new Dictionary<int, char>();   
     Random rnd = new Random(); 
     for (int i = 0; i <= 9; i++){
        dictN.Add(((int)i), (char)rnd.Next(65,90));
     }

    }

    public void printDicc(){
      foreach(KeyValuePair<int,char> ele in dictN){
         Console.WriteLine(ele.Key + " " + ele.Value);
      }
    }

  public List<char> replaceNumberInput(List<int>numbersEncrypt ){
            List<char> final = new List<char>();
            for (int i = 0; i < numbersEncrypt.Count; i++){
            if (dictN.ContainsKey(numbersEncrypt[i])){
               final.Add(dictN[numbersEncrypt[i]]);
            }
         }
        
        for(int i = 0; i < final.Count; i++){
         Console.WriteLine(final[i]);
        }
        return final;

       }
  }

