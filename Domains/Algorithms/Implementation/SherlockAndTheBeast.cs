using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
    {
        var t = Convert.ToInt32(Console.ReadLine());
        while(t > 0)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var result = "-1";
            if(n % 3 == 0)
                result = "5".PadRight(n, '5');
            else
            {
                var div3 = (n / 3) * 3;
                var div5 = n - div3;
                while(div5 % 5 != 0 && div3 > 0)
                {
                    div3 -= 3;
                    div5 = n - div3;
                }
                
                if(div3 == 0 && div5 % 5 == 0)
                    result = "3".PadRight(div5, '3');
                else if(div3 % 3 == 0 && div5 % 5 == 0)
                    result = "5".PadRight(div3, '5') + "3".PadRight(div5, '3');
            }
            Console.WriteLine(result);
            t--;
        }
    }
}
