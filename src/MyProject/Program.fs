// For more information see https://aka.ms/fsharp-console-apps
// Implicit entry point 
// printfn "Hello from F#"


// Explicit entry poiny
// [<EntryPoint>]
// let main args =
//     printfn "Arguments passed to function : %A" args
//     // Return 0. This indicates success.
//     0

// Explicit entry poiny

open MyLibrary 

[<EntryPoint>]
let main args =
    
    let myName = "Flavio"
    
    MyLibrary.Say.hello myName 
    // printfn "Arguments passed to function : %A" args
    // Return 0. This indicates success.
    0