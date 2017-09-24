// Learn more about F# at http://fsharp.org

open System

let add x y = 
    x + y

// let printAdd x y = 
//     printfn add x y


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let x = Convert.ToInt32(Console.ReadLine())
    let y = Convert.ToInt32(Console.ReadLine())
    let sum = add x y
    Console.WriteLine sum
    0 // return an integer exit code

//  C# code
//     
//     static void Main(String[] args) {
//         int val1 = Convert.ToInt32(Console.ReadLine());
//         int val2 = Convert.ToInt32(Console.ReadLine());
//         int sum = solveMeFirst(val1,val2);
//         Console.WriteLine(sum);
//     }
//   

