// Learn more about F# at http://fsharp.org

open System

let listaa = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]

let impares lista = 
    let esImpar x = x%2 = 1
    List.filter esImpar lista

let pares lista =
    let esPar x = x%2 = 0
    List.filter esPar lista



[<EntryPoint>]
let main argv =
    for i in pares listaa do
        printfn "%i" i
    printfn " "
    for i in impares listaa do
        printfn "%i" i
    0 // return an integer exit code
