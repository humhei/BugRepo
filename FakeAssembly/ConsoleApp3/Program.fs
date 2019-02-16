// Learn more about F# at http://fsharp.org

open System
open ClassLibrary1

[<EntryPoint>]
let main argv =
    let s = Say.packOptions
    printfn "Hello World from F#!"
    0 // return an integer exit code
