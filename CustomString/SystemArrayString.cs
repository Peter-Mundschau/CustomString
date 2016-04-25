using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString 

{
    public class SystemArrayString : ICustomString
    {
        
        public char[] originalArray;
        
        
        public SystemArrayString(string manipulatedString)
        {
            originalArray = manipulatedString.ToCharArray();
        }
        public override string ToString()
        {
            string maniputlatedString = null;    // or string maniputlatedString = ""
            foreach (char character in originalArray)
            {
                maniputlatedString += character.ToString();

            }
            return maniputlatedString;
        }



        public void Insert(int startIndex, string stringToInsert)
        {
            int size = originalArray.Count() + stringToInsert.Count();
            char[] tempArray = originalArray;
            originalArray = new char[size];
            

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (i>=startIndex&&i<(startIndex + stringToInsert.Length))
                {
                    originalArray[i] = stringToInsert.ToCharArray()[i - startIndex];
                }
                else
                {
                    int insert = i;
                    if (i>startIndex)
                    {
                        insert = i - startIndex;
                    }
                    originalArray[i] = tempArray[insert];
                }
            }

        }

        public int Length()
        {
            return originalArray.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            int endOfString = originalArray.Length - numCharsToRemove;
            for (int i = 0; i < originalArray.Length; i++)
            {
                if (i>=startIndex && i+numCharsToRemove<originalArray.Length)
                {
                    int removeindex = i;
                    originalArray[removeindex] = originalArray[removeindex + numCharsToRemove];
                }
            }
            char[] tempArray = new char[endOfString];
            for (int i = 0; i < endOfString && i<originalArray.Length; i++)
            {
                tempArray[i] = originalArray[i];
            }
            originalArray = tempArray;
         
        }





    }
}
