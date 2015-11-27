using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var T = Convert.ToInt32(Console.ReadLine());
        for(var i = 0; i < T; i++)
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            var splFrsLine = firstLine.Split(' ');
            var N = Convert.ToInt32(splFrsLine[0]);
            var K = Convert.ToInt32(splFrsLine[1]);
            var splScdLine = secondLine.Split(' ');
            var onTimeStudents = 0;
            for(var j = 0; j < N; j++)
            {
                if(Convert.ToInt32(splScdLine[j]) <= 0)
                    onTimeStudents++;
            }
            if(onTimeStudents >= K)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");                
        }
    }
}
