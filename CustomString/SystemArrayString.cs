using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString 

{
    public class SystemArrayString : ICustomString
    {
        public string StringToManipulate = "Hello World";
        public string string2Manipulate;
        public char[] manipulatedCharArray;
        
        public SystemArrayString(string manipulatedString)
        {
            manipulatedCharArray = manipulatedString.ToCharArray();
        }
        public override string ToString()
        {
            string finalString = null;
            foreach (char character in manipulatedCharArray)
            {
                finalString += character;

            }
            return finalString;
        }



        public void Insert(int startIndex, string stringToInsert)
        {

            string2Manipulate = Console.ReadLine();
            string2Manipulate = manipulatedCharArray.ToString();
            startIndex = Convert.ToInt32(Console.ReadLine());
            StringToManipulate.Insert(startIndex, string2Manipulate);

            char[] Array1 =StringToManipulate.ToCharArray();

            foreach (char item in Array1)
            {
                Console.Write(item);
            }
            
        }

        public int Length()
        {
            return manipulatedCharArray.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
         
        }

       public void MakeMeInsertAString()
        {

        }



    }
}
