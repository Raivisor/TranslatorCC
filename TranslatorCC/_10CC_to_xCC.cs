using System;
using System.Collections.Generic;
using System.Linq;

namespace TranslatorCC
{
    internal class _10CC_to_xCC
    {
        private Dictionary<double, char> chd = new Dictionary<double, char>
    {
        { 0 , '0'}, { 1 , '1'}, { 2, '2'}, { 3, '3'}, { 4, '4'}, { 5 ,'5'}, { 6, '6'}, { 7, '7'}, { 8, '8'},
        { 9, '9'}, { 10, 'A'}, { 11, 'B'}, { 12, 'C'}, { 13, 'D'}, { 14, 'E'}, {15, 'F'}
    };
        private Dictionary<char, double> proverka = new Dictionary<char, double>
    {
        { '0', 0}, { '1', 1 }, { '2' , 2}, { '3', 3 }, { '4', 4}, {'5' , 5}, { '6', 6}, { '7', 7},
        { '8', 8}, { '9', 9}, { 'A', 10}, { 'B', 11},{ 'C', 12}, {'D', 13}, { 'E', 14}, { 'F', 15}
    };

        public string Tr(string s, int kolvo, int cc)
        {
            if (s.Contains(',') || s.Contains('.'))
            {
                int a;
                if (s.Contains(','))
                {
                    a = s.IndexOf(',');
                }
                else
                {
                    a = s.IndexOf(".");
                }
                int first_part = 0;
                double second_part = 0;
                #region first_part
                for (int i = 0; i < a; i++)
                {
                    if (proverka[s[i]] >= 10)
                    {
                        return s[i] + " не входит в алфавит 10 системы счисления";
                    }
                    first_part += int.Parse(s[i].ToString()) * Convert.ToInt32(Math.Pow(10, a - 1 - i));

                }
                List<char> list = new();
                do
                {
                    int ost = first_part % cc;
                    list.Add(chd[ost]);
                    first_part = first_part / cc;
                } while (first_part > 0);
                list.Reverse();
                if (kolvo == 0)
                {
                    return String.Join("", list);
                }
                list.Add(',');
                #endregion
                int counter = -1;
                for (int i = a + 1; i < s.Length; i++)
                {
                    if (proverka[s[i]] >= 10)
                    {
                        return s[i] + " не входит в алфавит 10 системы счисления";
                    }
                    second_part += Convert.ToDouble(s[i].ToString()) * Math.Pow(10, counter);
                    counter--;
                }
                List<char> temp = new();
                for (int i = 0; i < kolvo; i++)
                {
                    counter = 0;
                    string b = (second_part * cc).ToString();
                    foreach (char c in b)
                    {
                        temp.Add(c);
                    }
                    double d = Math.Floor(second_part * cc);
                    list.Add(chd[d]);
                    if (!temp.Contains(',') && !temp.Contains('.'))
                    {
                        break;
                    }
                    else
                    {
                        do
                        {
                            temp[counter] = '0';
                            counter++;
                        } while (temp[counter] != ',');
                    }
                    b = String.Join("", temp);
                    temp.Clear();
                    second_part = Convert.ToDouble(b);
                }
                return String.Join("", list);
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (proverka[s[i]] >= 10)
                    {
                        return s[i] + " не входит в алфавит 10 системы счисления";
                    }
                }
                int num = int.Parse(s);
                List<char> list = new();
                while (num > 0)
                {
                    int ost = num % cc;
                    list.Add(chd[ost]);
                    num = num / cc;
                }
                list.Reverse();
                return String.Join("", list);
            }
        }
    }
}
