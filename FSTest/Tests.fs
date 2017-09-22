module Tests

open System
open Xunit
open FSLib

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``Apple turns into Appleyay`` () =
    let expected = "Appleyay"
    let actual = PigLatin.toPigLatin "Apple"

    Assert.Equal(expected, actual)

[<Fact>]
let ``Phillip turns into hillipPay`` () =
    let expected = "hillipPay"
    let actual = PigLatin.toPigLatin "Phillip"

    Assert.Equal(expected, actual)

[<Fact>]
let ``This is always going to fail`` () =
    Assert.True(false)