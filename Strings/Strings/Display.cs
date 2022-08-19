using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Display
    {

        string s = "The quick brown fox jumps over the lazy dog";

        public void printchar12()
        {
            Console.WriteLine(s[12]);
        }

        public void check()
        {
            Console.WriteLine(s.Contains("is"));
        }

        public void addstring()
        {
            string sr = "and killed it";
            s = s + sr;
            Console.WriteLine(s);
        }

        public void startwith()
        {
            if (s.StartsWith("dogs"))
            {
                Console.WriteLine("Yes it starts with dogs");
            }
            else
            {
                Console.WriteLine("No it does not start with dogs");
            }
        }

        public void Checkequal()
        {
            if (string.Equals(s, "The quick brown Fox jumps over the lazy Dog"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public void Len()
        {
            Console.WriteLine("The length of the string is " + s.Length);
        }

        public void repl(string word)
        {
            s.Replace("The", word);
        }

        public void split()
        {
            string[] sep = { "jumps"};
                  
          //Int32 count = 2;
            String[] strlist = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }

        }

        public void Animals()
        {
            if(s.Contains("fox"))

             {
                Console.WriteLine("fox");
            }
            if (s.Contains("dog"))
                {
                Console.WriteLine("dog");
            }
        }

        public void upper()
        {
            Console.WriteLine(s.ToUpper());
        }

        public void lower()
        {
            Console.WriteLine(s.ToLower());
        }


        public void index()
        {
            int rer = s.IndexOf('a');
            Console.WriteLine(rer);
        }

        public void lasind()
        {
            int inde = -1;
            bool fla = false;
            for(int i=s.Length-1;i>0;i--)
            {
                if (s[i]=='e')
                {
                    fla = true;
                    inde = i;
                    break;

                }
            }
            if(fla==false)
            {
                Console.WriteLine("Index of e not found");
            }
            else
            {
                Console.WriteLine(inde + "is the last index of e");

            }
            
        }

        public void constring()
        {
            const string first = "I WANDER'D lonely as a cloud That floats on high o'er vales and hills,\r\n\r\nWhen all at once I saw a crowd," +
                "A host, of golden daffodils;Beside the lake, beneath the trees, Fluttering and dancing in the breeze.";
        }
    }
}
