#!/bin/sh

[ ! -f biml.xsd ] && wget "http://bimlscript.com/Content/Docs/biml.xsd"

elems=`sed -n 's/^.*<xs:element .* name="\([^"]\+\)" .*/\1/p' biml.xsd |sort |uniq`
attrs=`sed -n 's/^.*<xs:attribute .* name="\([^"]\+\)" .*/\1/p' biml.xsd |sort |uniq`

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
    echo "let Biml = eltAttr \"Biml\" [xmlns \"http://schemas.varigence.com/biml.xsd\"]" >> $2.fs
    indent $2
    echo "let BimlAttr = eltAttr \"Biml\"" >> $2.fs
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
