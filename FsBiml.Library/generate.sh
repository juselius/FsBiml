#!/bin/sh

[ ! -f biml.xsd ] && wget "http://bimlscript.com/Content/Docs/biml.xsd"

elems=`sed -n 's/^.*<xs:element\( name=\| .* name=\)"\([^"]\+\)" .*/\2/p' biml.xsd |sort |uniq`
attrs=`sed -n 's/^.*<xs:attribute\( name=\| .* name=\)"\([^"]\+\)" .*/\2/p' biml.xsd |sort |uniq`

preamble () {
    cat << EOF > $1.fs
    namespace FsBiml

    module $1 =
        open Xml

EOF
}

indent () {
    echo -n "        " >> $1.fs
}

elt () {
    preamble $2
    indent $2
    echo "let BIML = eltAttr \"Biml\" [xmlns \"http://schemas.varigence.com/biml.xsd\"]" >> $2.fs
    echo ""  >> $2.fs
    for i in $1; do
        indent $2
        echo "let $i = elt \"$i\"" >> $2.fs
    done
    echo ""  >> $2.fs
    for i in $1; do
        indent $2
        echo "let ${i}Attr = eltAttr \"$i\""  >> $2.fs
    done
}

attr () {
    preamble $2
    for i in $1; do
        indent $2
        echo "let $i = attr \"$i\"" >> $2.fs
    done
}

elt "$elems" Element
attr "$attrs" Attr
