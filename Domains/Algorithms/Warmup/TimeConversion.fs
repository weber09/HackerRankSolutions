//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

[<EntryPoint>]
let main args =
    let timeArray = Console.ReadLine().Split(':')
    let timeDay = timeArray.[2].Substring(2)
    let hour = timeArray.[0] |> int
    if hour = 12 && timeDay.Equals("AM") then
        printfn "%s:%s:%s" "00" timeArray.[1] (timeArray.[2].Substring(0,2))
    else if hour <> 12 && timeDay.Equals("PM") then
        printfn "%d:%s:%s" (hour + 12) timeArray.[1] (timeArray.[2].Substring(0,2))  
    else
          printfn "%s:%s:%s" timeArray.[0] timeArray.[1] (timeArray.[2].Substring(0,2))
    0
