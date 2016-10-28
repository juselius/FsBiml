namespace FsBiml

// minimal xml combinator library
module Xml =
    // representable record for xml attributes
    type Attr =
        {
        name: string
        value: string
        }
        override this.ToString () =
            " " + this.name + "=\"" + this.value + "\""

    // helper for generating attribute functions
    let attr x y = { name = x; value = y }

    let  xmlns = attr "xmlns"

    // create a string from a list of strings
    let inline unwords l =
        List.fold (fun a x -> a + string x) "" l

    // xml elements inherit from Doc ()
    [<AbstractClass>]
    type Doc () =
        abstract Write : unit -> string
        override this.ToString () = this.Write ()

    // xml element dom
    type Elt (name: string, attrs: list<Attr>, doc: list<Doc>) =
        inherit Doc ()
        override this.Write () =
            let doc' =
                unwords doc
                |> (fun x -> if x.Length = 0 then x else x + "\n")
            "<" + name + unwords attrs + ">\n"
            + doc'
            + "</" + name + ">\n"

    // terminal xml text node
    type TextDoc (t : string) =
        inherit Doc ()
        override this.Write () = t
        override this.ToString () = this.Write ()

    // helper function for generating xml elements
    let elt name (d : list<Doc>) =
        Elt(name = name, attrs = [], doc = d)
    // helper function for generating xml elements with attributes
    let eltAttr name (a : list<Attr>) (d : list<Doc>) =
        Elt(name = name, attrs = a, doc = d)

    // xml header blurb
    let xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>"

    // generate text node
    let text x = TextDoc (x)
