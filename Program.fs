// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from DJ"

open System


let productOfList list =
    let rec tailRecursiveProduct lst acc =
        match lst with
        | [] -> acc  // Base case: if the list is empty, return the accumulated product
        | x :: xs -> tailRecursiveProduct xs (acc * x)  // Multiply the head with the accumulator and recurse on the tail
    tailRecursiveProduct list 1  // Start with an accumulator of 1

// Example usage
let numbers = [1; 2; 3; 4; 5]
let result = productOfList numbers
printfn "The product of the list %A is: %d" numbers result



let productOfOdds n =
    let rec tailRecursiveProduct current acc =
        if current < 1 then acc  // Base case: when current is less than 1, return the accumulated product
        else tailRecursiveProduct (current - 2) (acc * current)  // Multiply current with acc and recurse with current - 2
    tailRecursiveProduct n 1  // Start with accumulator 1

// Example usage
let main () =
    let exampleResult = productOfOdds 11
    printfn "The product of all odd numbers from 11 to 1 is: %d" exampleResult

main ()

let names = [" Anisha"; "Chahat  "; "  Divya  "; "  Shail  "]
let cleanedNames = names |> List.map (fun name -> name.Trim())

// Print the cleaned names
cleanedNames |> List.iter (printfn "%s")



let sumOfMultiples =
    seq { 1 .. 700 }
    |> Seq.filter (fun x -> x % 7 = 0 && x % 5 = 0)
    |> Seq.sum

printfn "The sum of numbers divisible by both 7 and 5 is: %d" sumOfMultiples



let concatenatedNames =
    ["Anisha"; "Rohit"; "Chahat"; "William"; "Mansi"; "David"; "Het"]
    |> List.filter (fun name -> name.ToLower().Contains("i"))
    |> List.fold (+) ""

printfn "Concatenated Names: %s" concatenatedNames
