using System;
class EncryptToNumber{


    // Here We Take every Number and multiplicate it by next one and the last one with the first one
    public List<int> encryptNumberList(List<int> numbers) 
    {
        List<int> numbersEncrypt = new List<int>(); 
        for (int i = 0; i < numbers.Count; i++) 
        {
            int calced =0; 

            if (i == numbers.Count - 1) 
            {

                calced += numbers.Last() * numbers[0]; 
    
            }
            else 
            {

                 calced += numbers[i] * numbers[i + 1]; 
            }

            numbersEncrypt.Add(calced); 
        }


        return numbersEncrypt; 
    }
}
