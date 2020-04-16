using System;
using System.Diagnostics;

namespace CtCi.Solutions.BigO
{
    public class Example12
    {
        private int iteration = 1;
        public void Permutation(string str) 
        {
            Permutation(str, "");

        }

        private void Permutation(string str, string prefix)
        {
            if (str.Length == 0)
            {
                Debug.WriteLine($"fim da iteração{prefix}");
                iteration++;
            }
            else 
            {
                for (int i = 0; i < str.Length; i++)
                {  
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    Debug.WriteLine($"iteration:{iteration}.{i}");
                    Debug.WriteLine($"perm({rem}, {prefix + str[i]})");
                    Permutation(rem, prefix + str[i]);
                }
            }
        }
    }
}
