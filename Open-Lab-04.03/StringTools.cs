using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length > 1)
            {
                string first = original.Remove(0, 1);
                string second = first.Remove(first.Length - 1);
                return second;
            }
            else
            {
                return original;
            }

        }
    }
}
