#r "bin/Release/FsBiml.dll"

open FsBiml
open FsBiml.Element

let biml =
    BIML [
        Packages [
            PackageAttr [Attr.Name "MyFirstFsBimlPakcage"] []
        ]
    ]

printfn "%s" <| string biml
