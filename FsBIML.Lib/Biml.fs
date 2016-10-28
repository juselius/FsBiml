namespace FsBIML

module Biml =
    open Xml

    //let Biml = eltAttr [attr.bimlns]
    let Annotations = elt "Annotations"
    let Connections = elt "Connections"
    let Cubes = elt "Cubes"
    let Databases = elt "Databases"
    let FileFormats = elt "FileFormats"
    let Metadata = elt "Metadata"
    let Packages = elt "Packages"
    let Projects = elt "Projects"
    let Principals = elt "Principals"
    let Schemas = elt "Schemas"
    let Servers = elt "Servers"
    let Tables = elt "Tables"
    let TabularModels = elt "TabularModels"

