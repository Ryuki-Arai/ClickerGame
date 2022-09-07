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
        if (303 < len) digit = $"{(bigint/(BigInteger)Mathf.Pow(10,303)).ToString("N0")} Centillion";
        else if (123 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 123)).ToString("N0")} Quadragintillion";
        else if (100 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 100)).ToString("N0")} Googol";
        else if (93 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 93)).ToString("N0")} Trigintillion";
        else if (72 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 72)).ToString("N0")} Tresvigintillion";
        else if (69 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 69)).ToString("N0")} Duovigintillion";
        else if (66 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 66)).ToString("N0")} Unvigintillion";
        else if (63 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 63)).ToString("N0")} Vigintillion";
        else if (60 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 60)).ToString("N0")} Novemdecillion";
        else if (57 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 57)).ToString("N0")} Octodecillion";
        else if (54 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 54)).ToString("N0")} SeptenDecillion";
        else if (51 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 51)).ToString("N0")} Sexdecillion";
        else if (48 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 48)).ToString("N0")} Quindecillion";
        else if (45 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 45)).ToString("N0")} QuatttuorDecillion";
        else if (42 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 42)).ToString("N0")} Tredecillion";
        else if (39 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 39)).ToString("N0")} Duodecillion";
        else if (36 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 36)).ToString("N0")} Undecillion";
        else if (33 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 33)).ToString("N0")} Decillion";
        else if (30 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 30)).ToString("N0")} Nonillion";
        else if (27 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 27)).ToString("N0")} Octillion";
        else if (24 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 24)).ToString("N0")} Septillion";
        else if (21 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 21)).ToString("N0")} Sextillion";
        else if (18 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 18)).ToString("N0")} Quintillion";
        else if (15 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 15)).ToString("N0")} Quadrillion";
        else if (12 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 12)).ToString("N0")} Trillion";
        else if (9 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 9)).ToString("N0")} Billion";
        else if (6 < len) digit = $"{(bigint / (BigInteger)Mathf.Pow(10, 6)).ToString("N0")} Million";
        else digit = bigint.ToString("N0");

        return digit;
    }
}