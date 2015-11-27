using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var T = Convert.ToInt32(Console.ReadLine());
        while(T > 0)
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var height = 1;
            for(var i = 0; i < N; i++)
            {
                if(i % 2 == 0)                
                    height *= 2;
                else
                    height++;
            }
            Console.WriteLine(height);
            T--;
        }
    }
}
