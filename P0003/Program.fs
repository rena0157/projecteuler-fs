
let primeFactors n =
    let rec getFactor number proposedFactor listOfFactors =
        
        if proposedFactor = number then
            proposedFactor::listOfFactors
            
        elif number % proposedFactor = 0L then
            getFactor (number / proposedFactor) proposedFactor (proposedFactor::listOfFactors)
            
        else
            getFactor number (proposedFactor + 1L) listOfFactors
            
    getFactor n 2L []

primeFactors 6008214751430L |> List.distinct |> printfn "%A"
