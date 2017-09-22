// Learn more about F# at http://fsharp.org

open System

let add x y = 
    x + y

// let printAdd x y = 
//     printfn add x y


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let x = Console.ReadLine()
    let y = Console.ReadLine()
    let sum = add x y
    Console.WriteLine sum
    0 // return an integer exit code

//  C# code
//  using System;
// using System.Collections.Generic;
// using System.IO;
// class Solution {
//     static int solveMeFirst(int a, int b) { 
//       return a + b;  
      
//     }
//     static void Main(String[] args) {
//         int val1 = Convert.ToInt32(Console.ReadLine());
//         int val2 = Convert.ToInt32(Console.ReadLine());
//         int sum = solveMeFirst(val1,val2);
//         Console.WriteLine(sum);
//     }
// }  

