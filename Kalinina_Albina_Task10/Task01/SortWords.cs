using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class SortWords
    {
        public delegate int CompareString(string firstElem, string secondElem);

        static public void Sort <T>(ref List<string> list, CompareString comparer)
        {
            string temp;
            if (comparer != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        var str1 = list[i];
                        var str2 = list[j];
                        if (comparer(str1, str2) == -1)
                        {
                            temp = str1;
                            str1 = str2;
                            str1 = temp;
                        }
                    }

                }
            }

        }
        public static int CompareToElemByLength(string firstElem, string secondElem)
        {
            return firstElem.Length.CompareTo(secondElem.Length);
        }

        static public int CompareElemByLength(string firstElem, string secondElem)
        {
            if (firstElem.Length > secondElem.Length)
            {
                return -1;
            }
            else
            {
                if (firstElem.Length > secondElem.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}

