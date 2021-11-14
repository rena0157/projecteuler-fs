
let reverseString (input : string) = input |> Seq.toArray |> Array.rev |> System.String

let isPalindromic num =
    let numAsString = num |> string
    numAsString |> reverseString = numAsString

let products = [
    for left in 0..999 do
        for right in 0..999 do
            yield (left * right)
]

let largestPalindrome = products |> List.where isPalindromic |> List.max

largestPalindrome |> string |> printfn "%s"
