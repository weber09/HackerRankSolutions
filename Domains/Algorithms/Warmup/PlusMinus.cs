using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var N = Convert.ToInt32(Console.ReadLine());
        var arrayStr = Console.ReadLine();
        var arrayInt = arrayStr.Split(' ');
        double positive = 0;
        double negative = 0;
        double zero = 0;
        for(var i = 0;i < N; i++)
        {
            var number = Convert.ToInt32(arrayInt[i]);
            if(number > 0)
             {
                positive++;
            }
            else if(number < 0)
               {
                negative++;
            }
                else
             {
                    zero++;
             }
        }
        
        Console.WriteLine(Math.Round(positive / N, 3));
        Console.WriteLine(Math.Round(negative / N, 3));
        Console.WriteLine(Math.Round(zero / N, 3));
    }
}
