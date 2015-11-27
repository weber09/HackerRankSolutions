using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var N = Convert.ToInt32(Console.ReadLine());
        var sumFirst = 0;
        var sumSecond = 0;
        for(var i = 0; i < N; i++)
        {
            var matrizStr = Console.ReadLine();
            var matrizInt = matrizStr.Split(' ');
            sumFirst += Convert.ToInt32(matrizInt[i]);
            sumSecond += Convert.ToInt32(matrizInt[N - i - 1]);
        }
        Console.WriteLine(Math.Abs(sumFirst - sumSecond));
    }
}
