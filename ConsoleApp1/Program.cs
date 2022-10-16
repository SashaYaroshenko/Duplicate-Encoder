using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.DuplicateEncode("abcabc)");
        }
    }

    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            string res = "";
            word = word.ToLower();
            char[] chars = word.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                bool flag = true;
                for(int c = i+1; c<chars.Length; c++)
                {
                  if(chars[i] == chars[c])
                  {
                        flag = false;
                        res += ")";
                      
                  }
                }
                if(flag==true)
                {
                    res += chars[i];
                }
            }
            chars = res.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if (chars[i]!=')')
                {
                    chars[i] = '(';
                }
            }
             word = new string(chars);
            return word;
        }
    }
}
