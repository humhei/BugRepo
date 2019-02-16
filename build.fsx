#if FAKE
#r "paket: groupref Main //"
#endif
#if !FAKE
#r "Facades/netstandard"
#r "netstandard"
#endif
#load "./.fake/build.fsx/intellisense.fsx"

open System
open ClassLibrary1

let s = ClassLibrary1.Class1.Run