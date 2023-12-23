using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorCC
{
    internal class Remover_Zero
    {
        public string RemoveZero(string s)
        {
            if (s[s.Length - 1] == '0' && (s.Contains(',') || s.Contains('.')))
            {
                List<char> temp = new();
                foreach (char ch in s)
                {
                    temp.Add(ch);
                }
                while (temp[temp.Count - 1] == '0')
                {
                    temp.RemoveAt(temp.Count - 1);
                    if (temp[temp.Count - 1] == ',')
                    {
                        temp.RemoveAt(temp.Count - 1);
                        s = "";
                        foreach (char ch in temp)
                        {
                            s = s + ch;
                        }
                        return s;
                    }
                }
                s = "";
                foreach (char ch in temp)
                {
                    s += ch;
                }
                return s;
            }
            else
            {
                return s;
            }
        }
    }
}
