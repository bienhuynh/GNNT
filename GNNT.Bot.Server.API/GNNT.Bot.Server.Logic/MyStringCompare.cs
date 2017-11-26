using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNNT.Bot.Server.Logic
{
    public class MyStringCompare
    {
        public string convertToUnSign2(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        public double Compare(string a, string b)
        {

            char[] delimiterChars = { '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '[', ']', '{', '}', '|', ';', ':', '\\', '.', '/', '<', '>', '?', '\t', ',', ' ' };
            a = convertToUnSign2(a);
            b = convertToUnSign2(b);
            a = a.Trim(delimiterChars);
            b = b.Trim(delimiterChars);
            a = a.ToUpper();
            b = b.ToUpper();

            string[] wordsA = a.Split(delimiterChars);
            string[] wordsB = b.Split(delimiterChars);

            int count = 0;
            foreach (string s in wordsA)
            {
                if (wordsB.Contains(s))
                {
                    count++;
                }
            }

            return count / (double)wordsB.Length * 100.0;

        }
    }
}

