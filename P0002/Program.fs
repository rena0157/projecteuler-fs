open Checked

let isEven n = n % 2 = 0

let fib maxValue =
    let isLessThanMax i = i < maxValue

    seq {
        let mutable previous = 0
        let mutable current = 1
    
        for _ in 0 .. 1_000 do
            let next = current + previous
            previous <- current
            current <- next
            next
    } |> Seq.takeWhile isLessThanMax

let sum = fib 4_000_000 |> Seq.where isEven |> Seq.sum

printfn $"Sum: %d{sum}"