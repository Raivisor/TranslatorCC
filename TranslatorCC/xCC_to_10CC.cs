using System;
using System.Collections.Generic;
using System.Linq;

namespace TranslatorCC
{
    internal class xCC_to_10CC
    {
        private Dictionary<char, double> chd = new Dictionary<char, double>
    {
        { '0', 0}, { '1', 1 }, { '2' , 2}, { '3', 3 }, { '4', 4}, {'5' , 5}, { '6', 6}, { '7', 7},
        { '8', 8}, { '9', 9}, { 'A', 10}, { 'B', 11},{ 'C', 12}, {'D', 13}, { 'E', 14}, { 'F', 15}
    };

        public string Tr(string x, int cc)
        {
            double answer = 0;
            char[] chars = x.ToCharArray();
            if (chars.Contains(',') || chars.Contains('.'))
            {
                List<string> temp = new List<string>();
                int a;
                if (chars.Contains(','))
                {
                    a = Array.IndexOf(chars, ',');
                }
                else
                {
                    a = Array.IndexOf(chars, '.');
                }
                int counter = 0;
                for (int i = a - 1; i >= 0; i--)
                {
                    if (chd[chars[i]] >= cc)
                    {
                        return chars[i] + " не входит в алфавит " + cc.ToString() + " системы счисления";
                    }
                    temp.Add((chd[chars[i]] * Math.Pow(cc, counter)).ToString());
                    counter++;
                }
                counter = -1;
                for (int i = a + 1; i < chars.Length; i++)
                {
                    if (chd[chars[i]] >= cc)
                    {
                        return chars[i] + " не входит в алфавит " + cc.ToString() + " системы счисления";
                    }
                    temp.Add((chd[chars[i]] * Math.Pow(cc, counter)).ToString());
                    counter--;
                }
                foreach (string s in temp)
                {
                    answer += Convert.ToDouble(s);
                }
            }
            else
            {
                int counter = 0;
                for (int i = chars.Length - 1; i >= 0; i--)
                {
                    if (chd[chars[i]] >= cc)
                    {
                        return chars[i] + " не входит в алфавит " + cc.ToString() + " системы счисления";
                    }
                    answer += chd[chars[i]] * Math.Pow(cc, counter);
                    counter++;
                }
            }
            return answer.ToString();
        }
    }
}
