﻿namespace ClassLibrary1

module Say =
    let hello name =
        printfn "Hello %s" name

    let packOptions =
        Fake.DotNet.DotNet.PackOptions.Create()