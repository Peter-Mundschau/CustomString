using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class SystemString 
    {
        public string StringToManipulate;
        public SystemString(string inputString)
        {
            StringToManipulate = inputString;
        }
        public override string ToString()
        {
            return StringToManipulate;
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            StringToManipulate.Insert(startIndex, stringToInsert);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            StringToManipulate.Remove(startIndex, numCharsToRemove);
        }
        public int Length()
        {
            return StringToManipulate.Length;
        }

    }
}
