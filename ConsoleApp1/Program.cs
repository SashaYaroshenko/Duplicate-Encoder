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
            word = word.ToLower();
            char[] chars = word.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                for(int c = i+1; c<chars.Length; c++)
                {
                  if(chars[i] == chars[c])
                  {
                      word =  word.Replace(chars[c], ')') ;
                        break;
                  }
                }
            }
            foreach(char c in word)
            {
                if(c!=')')
                {
                  word =  word.Replace(c, '(');
                }
            }
            return word;
        }
    }
}
