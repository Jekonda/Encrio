using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cipher
{
    public static class DataSource
    {
        public static readonly List<Alphabet> EncTable = new List<Alphabet>
        {
            new Alphabet
            {
                Letter = "A",
                Position = 0,
                EncPosition = 20
            },
            new Alphabet
            {
                Letter = "B",
                Position = 1,
                EncPosition = 15
            },
            new Alphabet
            {
                Letter = "C",
                Position = 2,
                EncPosition = 7
            },
            new Alphabet
            {
                Letter = "D",
                Position = 3,
                EncPosition = 4
            },
            new Alphabet
            {
                Letter = "E",
                Position = 4,
                EncPosition = 8
            },
            new Alphabet
            {
                Letter = "F",
                Position = 5,
                EncPosition = 17
            },
            new Alphabet
            {
                Letter = "G",
                Position = 6,
                EncPosition = 10
            },
            new Alphabet
            {
                Letter = "H",
                Position = 7,
                EncPosition = 22
            },
            new Alphabet
            {
                Letter = "I",
                Position = 8,
                EncPosition = 1
            },
            new Alphabet
            {
                Letter = "J",
                Position = 9,
                EncPosition = 18
            },
            new Alphabet
            {
                Letter = "K",
                Position = 10,
                EncPosition = 6
            },
            new Alphabet
            {
                Letter = "L",
                Position = 11,
                EncPosition = 21
            },
            new Alphabet
            {
                Letter = "M",
                Position = 12,
                EncPosition = 26
            },
            new Alphabet
            {
                Letter = "N",
                Position = 13,
                EncPosition = 24
            },
            new Alphabet
            {
                Letter = "O",
                Position = 14,
                EncPosition = 13
            },
            new Alphabet
            {
                Letter = "P",
                Position = 15,
                EncPosition = 23
            },
            new Alphabet
            {
                Letter = "Q",
                Position = 16,
                EncPosition = 16
            },
            new Alphabet
            {
                Letter = "R",
                Position = 17,
                EncPosition = 0
            },
            new Alphabet
            {
                Letter = "S",
                Position = 18,
                EncPosition = 2
            },
            new Alphabet
            {
                Letter = "T",
                Position = 19,
                EncPosition = 11
            },
            new Alphabet
            {
                Letter = "U",
                Position = 20,
                EncPosition = 25
            },
            new Alphabet
            {
                Letter = "V",
                Position = 21,
                EncPosition = 5
            },
            new Alphabet
            {
                Letter = "W",
                Position = 22,
                EncPosition = 3
            },
            new Alphabet
            {
                Letter = "X",
                Position = 23,
                EncPosition = 19
            },
            new Alphabet
            {
                Letter = "Y",
                Position = 24,
                EncPosition = 12
            },
            new Alphabet
            {
                Letter = "Z",
                Position = 25,
                EncPosition = 9
            },
            new Alphabet
            {
                Letter = "_",
                Position = 26,
                EncPosition = 14
            }
        };

        public static readonly string GASLO = "SLOGAN_";
        public static readonly string TASK4KEY = "ETHERIUM";
        public static readonly string TASK6KEY = "FORECAST";

        public static readonly string[,] Matrix =
        {
            {"K", "W", "R", "H", ","},
            {"P", "T", "B", "N", "U"},
            {"_", "D", "O", "Z", "E"},
            {"J", "F", ".", "C", "Y"},
            {"V", "G", "A", "I", "X"},
            {"M", "-", "Q", "L", "S"}
        };
    }
}