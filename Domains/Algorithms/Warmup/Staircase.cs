using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var N = Convert.ToInt32(Console.ReadLine());
        for(var i = 0; i < N; i++)
        {
            var str = "";
            var j = 0 ;
            for(; j < N - i - 1; j++)
                str += " ";
            for(var l = j; l < N; l++)
                str += "#";
            Console.WriteLine(str);
        }
    }
}
