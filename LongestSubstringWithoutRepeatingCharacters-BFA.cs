using System;
using System.Linq;
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var longestString = String.Empty;
        var chars = s.ToCharArray();
        var counter = 0;
        
        if (s.Length == 1) return 1;
        if (s.Length == 0) return 0;

        for (var i = 0; i < chars.Length; i++)
        {
            var subString = String.Empty;
            var tempSubString = String.Empty;
            for (var j = counter; j < chars.Length; j++)           
            {
                tempSubString += chars[j];
                if(IsDistinct(tempSubString))
                {
                    subString = tempSubString;
                    if(subString.Length > longestString.Length)
                    {
                         longestString = subString;
                    }
                }else
                {
                    if(subString.Length > longestString.Length)
                    {
                         longestString = subString;
                    }
                    break;
                }
            }
            counter ++;
        }
        return longestString.Length;
    }
    
    private bool IsDistinct(string subString)
    {
        return subString.Distinct().Count() == subString.Count();
    }
}