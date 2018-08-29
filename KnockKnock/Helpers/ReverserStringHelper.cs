using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnock.Helpers
{
    public static class ReverserStringHelper
    {
        public static string ReverseString(string str)
        {
            var reversedWords = string.Join(" ",
                                        str.Split(' ')
                                       .Select(x => new String(x.Reverse().ToArray())));
            return reversedWords;
        }
    }
}