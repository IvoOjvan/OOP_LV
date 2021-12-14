using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    static class EmailHelper
    {
        public static bool IsValidAddress(string address)
        {
            string gmail = "gmail.com";
            string ferit = "ferit.hr";
            int flag = 0;

            foreach(char character in address)
            {
                if (character.Equals("@")){
                    flag++;
                }   
            }

            string[] words = address.Split("@");
            string domain = words[words.Length - 1];

            if (flag > 1)
                return false;

            return address.Contains("@") && (domain.Equals(gmail) || domain.Equals(ferit));
        }

        public static bool CheckForFeritAddress(string address)
        {
            string ferit = "ferit.hr";

            string[] words = address.Split("@");
            string domain = words[words.Length - 1];

            return address.Contains("@") && domain.Equals(ferit);
        }
    }
}
