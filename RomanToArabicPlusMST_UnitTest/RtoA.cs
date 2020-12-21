using System;
using System.Collections;

namespace RomanToArabicNS
{
    public class RtoA
    {
        static private Hashtable convertTable;

        static void Main(string[] args)
        {

        }
        static public int romanToArabic(string romanText)
        {
            //initials the convertTable
            convertTable = new Hashtable();
            convertTable.Add('I', 1);
            convertTable.Add('V', 5);
            convertTable.Add('X', 10);
            convertTable.Add('L', 50);
            convertTable.Add('C', 100);
            convertTable.Add('D', 500);
            convertTable.Add('M', 1000);

            //see if the text is blank retun 0
            if (romanText.Length == 0)
                return 0;

            //Set the string to upper case
            romanText = romanText.ToUpper();

            
            // Convert the letters' values.
            int total = 0;
            int lastValu = 0;
            for (int i = romanText.Length - 1; i >= 0; i--)
            {
                int new_value = (int)convertTable[romanText[i]];

                // See if we should add or subtract.
                if (new_value < lastValu)
                    total -= new_value;
                else
                {
                    total += new_value;
                    lastValu = new_value;
                }
            }

            // Return the result.
            return total;
        }
    }
}

