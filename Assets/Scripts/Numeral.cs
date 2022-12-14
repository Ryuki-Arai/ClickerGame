using System.Numerics;

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
    static public string Numeration(BigInteger bigint)
    {
        var len = bigint.ToString().Length;
        string digit = default;
        if(306 < len) digit = $"{(bigint / Pow(10, 303)).ToString("N0")} Centillion";
        else if (303 < len) digit = $"{((float)(bigint / Pow(10, 300)) / 1000).ToString("F3")} Centillion";
        else if (126 < len) digit = $"{(bigint / Pow(10, 123)).ToString("N0")} Quadragintillion";
        else if (123 < len) digit = $"{((float)(bigint / Pow(10, 120)) / 1000).ToString("F3")} Quadragintillion";
        else if (103 < len) digit = $"{(bigint / Pow(10, 100)).ToString("N0")} Googol";
        else if (100 < len) digit = $"{((float)(bigint / Pow(10, 97)) / 1000).ToString("F3")} Googol";
        else if (96 < len) digit = $"{(bigint / Pow(10, 93)).ToString("N0")} Trigintillion";
        else if (93 < len) digit = $"{((float)(bigint / Pow(10, 90)) / 1000).ToString("F3")} Trigintillion";
        else if (75 < len) digit = $"{(bigint / Pow(10, 72)).ToString("N0")} Tresvigintillion";
        else if (72 < len) digit = $"{((float)(bigint / Pow(10, 69)) / 1000).ToString("F3")} Tresvigintillion";
        else if (69 < len) digit = $"{((float)(bigint / Pow(10, 66)) / 1000).ToString("F3")} Duovigintillion";
        else if (66 < len) digit = $"{((float)(bigint / Pow(10, 63)) / 1000).ToString("F3")} Unvigintillion";
        else if (63 < len) digit = $"{((float)(bigint / Pow(10, 60)) / 1000).ToString("F3")} Vigintillion";
        else if (60 < len) digit = $"{((float)(bigint / Pow(10, 57)) / 1000).ToString("F3")} Novemdecillion";
        else if (57 < len) digit = $"{((float)(bigint / Pow(10, 54)) / 1000).ToString("F3")} Octodecillion";
        else if (54 < len) digit = $"{((float)(bigint / Pow(10, 51)) / 1000).ToString("F3")} SeptenDecillion";
        else if (51 < len) digit = $"{((float)(bigint / Pow(10, 48)) / 1000).ToString("F3")} Sexdecillion";
        else if (48 < len) digit = $"{((float)(bigint / Pow(10, 45)) / 1000).ToString("F3")} Quindecillion";
        else if (45 < len) digit = $"{((float)(bigint / Pow(10, 42)) / 1000).ToString("F3")} QuatttuorDecillion";
        else if (42 < len) digit = $"{((float)(bigint / Pow(10, 39)) / 1000).ToString("F3")} Tredecillion";
        else if (39 < len) digit = $"{((float)(bigint / Pow(10, 36)) / 1000).ToString("F3")} Duodecillion";
        else if (36 < len) digit = $"{((float)(bigint / Pow(10, 33)) / 1000).ToString("F3")} Undecillion";
        else if (33 < len) digit = $"{((float)(bigint / Pow(10, 30)) / 1000).ToString("F3")} Decillion";
        else if (30 < len) digit = $"{((float)(bigint / Pow(10, 27)) / 1000).ToString("F3")} Nonillion";
        else if (27 < len) digit = $"{((float)(bigint / Pow(10, 24)) / 1000).ToString("F3")} Octillion";
        else if (24 < len) digit = $"{((float)(bigint / Pow(10, 21)) / 1000).ToString("F3")} Septillion";
        else if (21 < len) digit = $"{((float)(bigint / Pow(10, 18)) / 1000).ToString("F3")} Sextillion";
        else if (18 < len) digit = $"{((float)(bigint / Pow(10, 15)) / 1000).ToString("F3")} Quintillion";
        else if (15 < len) digit = $"{((float)(bigint / Pow(10, 12)) / 1000).ToString("F3")} Quadrillion";
        else if (12 < len) digit = $"{((float)(bigint / Pow(10, 9)) / 1000).ToString("F3")} Trillion";
        else if (9 < len) digit = $"{((float)(bigint / Pow(10, 6)) / 1000).ToString("F3")} Billion";
        else if (6 < len) digit = $"{((float)(bigint / Pow(10, 3)) / 1000).ToString("F3")} Million";
        else digit = bigint.ToString("N0");

        return digit;
    }

    static public BigInteger Pow(int n, int x)
    {
        BigInteger ans = 1;
        for (int i = 0; i < x; i++)
        {
            ans *= n;
        }
        return ans;
    }
}