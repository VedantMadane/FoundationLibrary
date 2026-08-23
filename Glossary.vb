Imports System.Runtime.CompilerServices
'TODO : Να περαστουν και οι τόνοι , να αλλαξουμε μερικα πραγματα απο char σε string
Public Module Glossary
    Enum Languages
        None
        English
        Greek
    End Enum

    Private ReadOnly Clusters As New HashSet(Of String) From {
                                                              _ 'English
    "bl", "br", "cl", "cr",
        "dr", "fl", "fr",
        "gl", "gr",
        "pl", "pr",
        "sk", "sl", "sm", "sn", "sp", "st", "sw",
        "tr", "tw", "dw",
        "nd", "nt", "nk",
        "ld", "lt",
        "mp", "ft", "pt", "kt",
        "rd", "rt", "rn", "rm",
        "lp", "lk",
        "skr", "skw", "skl",
        "spr", "str", "spl",
        "sts", "sps", "nks", "lpt", "cts", "mps",
                                                 _ 'Greek
        "βλ", "βρ",
        "γδ", "γλ", "γν", "γρ",
        "δρ",
        "θρ", "θλ",
        "κλ", "κρ",
        "πλ", "πν", "πρ", "πτ",
        "σκ", "σμ", "σπ", "στ", "σφ", "σχ",
        "τρ",
        "φλ", "φρ",
        "χλ", "χν", "χρ",
        "στρ", "σπρ", "σκλ", "σκρ"
    }

    Private ReadOnly Vowels As New HashSet(Of Char) From {
    "a", "e", "i", "o", "u", "y", ' English
    "α", "ε", "η", "ι", "ο", "υ", "ω" 'Greek
    }

    Private ReadOnly Consonants As New HashSet(Of Char) From {
             "b", "c", "d", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z", 'English
              "β", "γ", "δ", "ζ", "θ", "κ", "λ", "μ", "ν", "ξ", "π", "ρ", "σ", "τ", "φ", "χ", "ψ", "ς" 'Greek
        }

    Private ReadOnly ConvertDigraphsConsonants As New Dictionary(Of String, String) From
        {
         _ 'English to Greek    
        {"th", "Θ"},
        {"ps", "ψ"},
        {"3", "ξ"},
        {"d", "ντ"},
        {"b", "μπ"},
        {"j", "τζ"},
        {"g", "γκ"},
        {"ks", "ξ"},
                    _ ' Greek to English
        {"θ", "th"},
        {"ψ", "ps"},
        {"μπ", "b"},
        {"τζ", "j"},
        {"ντ", "d"},
        {"γκ", "g"},
        {"ξ", "ks"}
    }
    <Extension>
    Public Function isConsonantCluster(C As Char()) As Boolean
        Dim Cluster As String = New String(C).ToLowerInvariant
        Return Clusters.Contains(Cluster)
        Return False
    End Function
    <Extension>
    Public Function IsVowel(c As Char) As Boolean
        If Vowels.Contains(c) Then Return True
        Return False
    End Function

    <Extension>
    Public Function IsConsonant(C As Char) As Boolean
        If Consonants.Contains(C) Then Return True
        Return False
    End Function
    <Extension>
    Public Function WhatLanguageIs(C As Char) As Languages
        If C >= "a" And C <= "z" Or C >= "A" And C <= "Z" Then Return Languages.English
        If C >= "α" And C <= "ω" Or C >= "Α" And C <= "Ω" Then Return Languages.Greek
        Return Nothing
    End Function

    Public Function ConvertLanguage(C As Char, MainLanguage As Languages, ToLanguage As Languages) As Char
        If MainLanguage = Languages.English AndAlso ToLanguage = Languages.Greek Then
            Select Case C
                Case "a" : Return "α"
                Case "b" : Return "β"
                Case "c" : Return "σ"
                Case "d" : Return "δ"
                Case "e" : Return "ε"
                Case "f" : Return "φ"
                Case "g" : Return "γ"
                Case "h" : Return "η"
                Case "i" : Return "ι"
                Case "j" : Return "ξ"
                Case "k" : Return "κ"
                Case "l" : Return "λ"
                Case "m" : Return "μ"
                Case "n" : Return "ν"
                Case "o" : Return "ο"
                Case "p" : Return "π"
                Case "q" : Return "θ"
                Case "r" : Return "ρ"
                Case "s" : Return "ς"
                Case "t" : Return "τ"
                Case "u" : Return "υ"
                Case "v" : Return "β"
                Case "w" : Return "ω"
                Case "x" : Return "χ"
                Case "y" : Return "ψ"
                Case "z" : Return "ζ"

                Case "A" : Return "Α"
                Case "B" : Return "Β"
                Case "C" : Return "Σ"
                Case "D" : Return "Δ"
                Case "E" : Return "Ε"
                Case "F" : Return "Φ"
                Case "G" : Return "Γ"
                Case "H" : Return "Η"
                Case "I" : Return "Ι"
                Case "J" : Return "Ξ"
                Case "K" : Return "Κ"
                Case "L" : Return "Λ"
                Case "M" : Return "Μ"
                Case "N" : Return "Ν"
                Case "O" : Return "Ο"
                Case "P" : Return "Π"
                Case "Q" : Return "Θ"
                Case "R" : Return "Ρ"
                Case "S" : Return "Σ"
                Case "T" : Return "Τ"
                Case "U" : Return "Υ"
                Case "V" : Return "Β"
                Case "W" : Return "Ω"
                Case "X" : Return "Χ"
                Case "Y" : Return "Ψ"
                Case "z" : Return "Ζ"
            End Select
        ElseIf MainLanguage = Languages.English AndAlso ToLanguage = Languages.Greek Then
            Select Case C
                Case "α" : Return "a"
                Case "β" : Return "b"
                Case "γ" : Return "g"
                Case "δ" : Return "d"
                Case "ε" : Return "ε"
                Case "ζ" : Return "z"
                Case "η" : Return "h"
                Case "Θ" : Return "q"
                Case "ι" : Return "i"
                Case "κ" : Return "k"
                Case "λ" : Return "l"
                Case "μ" : Return "m"
                Case "ν" : Return "n"
                Case "ξ" : Return "j"
                Case "o" : Return "o"
                Case "π" : Return "p"
                Case "ρ" : Return "r"
                Case "σ" : Return "c"
                Case "τ" : Return "t"
                Case "υ" : Return "u"
                Case "φ" : Return "f"
                Case "χ" : Return "x"
                Case "ψ" : Return "y"
                Case "ω" : Return "w"
                Case "ς" : Return "s"

                Case "Α" : Return "A"
                Case "Β" : Return "B"
                Case "Γ" : Return "G"
                Case "Δ" : Return "D"
                Case "Ε" : Return "E"
                Case "Ζ" : Return "Z"
                Case "Η" : Return "H"
                Case "Θ" : Return "Q"
                Case "Ι" : Return "I"
                Case "Κ" : Return "K"
                Case "Λ" : Return "L"
                Case "Μ" : Return "M"
                Case "Ν" : Return "N"
                Case "Ξ" : Return "J"
                Case "Ο" : Return "O"
                Case "Π" : Return "P"
                Case "Ρ" : Return "R"
                Case "Σ" : Return "S"
                Case "Τ" : Return "T"
                Case "Υ" : Return "U"
                Case "Φ" : Return "F"
                Case "Χ" : Return "X"
                Case "Ψ" : Return "Y"
                Case "Ω" : Return "W"
            End Select
        End If

        Return C
    End Function
    <Extension>
    Public Function IsLanguage(C As Char, TypeLanguage As Languages) As Boolean
        If TypeLanguage = Languages.English Then
            If C >= "a" And C <= "z" Or C >= "A" And C <= "Z" Then Return True
        ElseIf TypeLanguage = Languages.Greek Then
            If C >= "α" And C <= "ω" Or C >= "Α" And C <= "Ω" Then Return True
        Else
            Return True
        End If
        Return False
    End Function
End Module
