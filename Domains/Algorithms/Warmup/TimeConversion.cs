using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var hourAndTimeStr = Console.ReadLine();
        var splitHour = hourAndTimeStr.Split(':');
        var hour = Convert.ToInt32(splitHour[0]);
        var time = splitHour[splitHour.Length - 1].Substring(splitHour[splitHour.Length - 1].Length - 2);
        if(time.Equals("PM") && hour != 12)
            splitHour[0] = (hour + 12).ToString();
        else if(time.Equals("AM") && hour == 12)
                splitHour[0] = "00";
            
        Console.WriteLine(string.Format("{0}:{1}:{2}", splitHour[0], splitHour[1], splitHour[splitHour.Length - 1].Substring(0, 2)));
        
    }
}
