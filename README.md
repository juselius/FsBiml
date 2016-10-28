# F# combinator library for BIML

FsBiml is a simple combinator library for generating BIML XML output. The
library is heavily inspired by the ``WebSharper`` HTML combinators and
``Haskell Blaze`` library.

The library allows users to generate BIML output in a clean, compact and
typesafe manner.

## Install

To compile the library from the command line use
``MBBuild.exe`` (Windows) or ``xbuild`` (Linux/Mono)

```sh
$ cd /path/to/FsBiml
$ .paket/paket.bootstrapper.exe
$ .paket/paket.exe install
$ xbuild /p:Configuration=Release
```
**Note**: Under Windows the F# compiler (``fsc.exe 14.0.23413.0``)
receives a stack overflow exception when compiling in ``Debug`` mode.

## Example
Copy and paste into F# Interactive (``fsi.exe`` or ``fsharpi``):
```fsharp
#r "FsBiml.Library/bin/Release/FsBiml.Library.dll"

open FsBiml
open FsBiml.Element

let biml =
    BIML [
        Packages [
            PackageAttr [Attr.Name "MyFirstFsBimlPakcage"] []
        ]
    ]

printfn "%s" <| string biml
```
