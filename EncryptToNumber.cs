using System;
class EncryptToNumber{

    public List<int> encryptNumberList(List<int> numbers) // Here we make Function that takes the ints that we converted from chars to ints
    {
        List<int> numbersEncrypt = new List<int>(); // Making a new List so we can add the multiplicated Ints
        for (int i = 0; i < numbers.Count; i++) // For every Int in our Numbers List
        {
            int calced =0; // Declaring a  empty Int

            if (i == numbers.Count - 1) // if we are at the last Element from our List 
            {

                calced += numbers.Last() * numbers[0]; // We multiplicate the Last Int from our list and Multiplicate it with the first one 
    
            }
            else // Else 
            {

                 calced += numbers[i] * numbers[i + 1]; // We just Multiplicate the Int in our List with the Next one 
            }

            numbersEncrypt.Add(calced); // Here we Add every Factor of our multiplicated Numbes 
        }

        for (int i = 0; i < numbersEncrypt.Count; i++) // for every Int in our List
        {

         Console.WriteLine(numbersEncrypt[i]); // We print it

        }
        return numbersEncrypt; // And return the Value
    }
}
