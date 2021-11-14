
printfn "Project Euler: Problem 1"
printfn "Find the sum of all the multiples of 3 or 5 below 1000."

let numbers = [|1 .. 999|]

let printNumbers n =
    n |> Array.iter ( fun x -> (printf $"%d{x} " ))
    printf "\n"

let isMultipleOfThree n =
    n % 3 = 0

let isMultipleOfFive n =
    n % 5 = 0

// printNumbers numbers

let filteredNumbers
    = numbers |> Array.where (fun i -> (isMultipleOfFive i || isMultipleOfThree i))

// printNumbers filteredNumbers

let answer = filteredNumbers |> Array.sum
printfn $"The answer is %d{answer}"