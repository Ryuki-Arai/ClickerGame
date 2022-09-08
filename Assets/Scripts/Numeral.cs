using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

/*Numeration
{
    Million = 6,
    Billion = 9,
    Trillion = 12,
    Quadrillion = 15,
    Quintillion = 18,
    Sextillion = 21,
    Septillion = 24,
    Octillion = 27,
    Nonillion = 30,
    Decillion = 33,
    Undecillion = 36,
    Duodecillion = 39,
    Tredecillion = 42,
    Quatttuor_Decillion = 45,
    Quindecillion = 48,
    Sexdecillion = 51,
    Septen_Decillion = 54,
    Octodecillion = 57,
    Novemdecillion = 60,
    Vigintillion = 63,
    Unvigintillion = 66,
    Duovigintillion = 69,
    Tresvigintillion = 72,
    Trigintillion = 93,
    Googol = 100,
    Quadragintillion = 123,
    Centillion = 303,
}*/

public class Numeral
{
    static public string Numelal(BigInteger bigint)
    {
        var len = bigint.ToString().Length;
        string digit = default;
        if (303 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Centillion";
        else if (123 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Quadragintillion";
        else if (100 < len) digit = $"{((float)(bigint / BigInteger.Parse("10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Googol";
        else if (93 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Trigintillion";
        else if (72 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Tresvigintillion";
        else if (69 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Duovigintillion";
        else if (66 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Unvigintillion";
        else if (63 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Vigintillion";
        else if (60 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Novemdecillion";
        else if (57 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Octodecillion";
        else if (54 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} SeptenDecillion";
        else if (51 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Sexdecillion";
        else if (48 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000000")) / 1000).ToString("F3")} Quindecillion";
        else if (45 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000000")) / 1000).ToString("F3")} QuatttuorDecillion";
        else if (42 < len) digit = $"{((float)(bigint / BigInteger.Parse("1000000000000000000000000000000000000000")) / 1000).ToString("F3")} Tredecillion";
        else if (39 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 36)) / 1000).ToString("F3")} Duodecillion";
        else if (36 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 33)) / 1000).ToString("F3")} Undecillion";
        else if (33 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 30)) / 1000).ToString("F3")} Decillion";
        else if (30 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 27)) / 1000).ToString("F3")} Nonillion";
        else if (27 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 24)) / 1000).ToString("F3")} Octillion";
        else if (24 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 21)) / 1000).ToString("F3")} Septillion";
        else if (21 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 18)) / 1000).ToString("F3")} Sextillion";
        else if (18 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 15)) / 1000).ToString("F3")} Quintillion";
        else if (15 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 12)) / 1000).ToString("F3")} Quadrillion";
        else if (12 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 9)) / 1000).ToString("F3")} Trillion";
        else if (9 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 6)) / 1000).ToString("F3")} Billion";
        else if (6 < len) digit = $"{((float)(bigint / (BigInteger)Mathf.Pow(10, 3)) / 1000).ToString("F3")} Million";
        else digit = bigint.ToString("N0");

        return digit;
    }
}