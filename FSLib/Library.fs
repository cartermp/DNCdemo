namespace FSLib

open System

module PigLatin =
    let toPigLatin (str: string) =
        // Starts with a vowel, then it's the word + "yay"
        // If not, then it's the word (Banana --> ananaBay)

        let vowels = set ['a'; 'e'; 'i'; 'o'; 'u']

        let firstChar = str.[0]

        if vowels.Contains (Char.ToLower firstChar) then
            str + "yay"
        else
            str.[1..] + Char.ToString(firstChar) + "ay"