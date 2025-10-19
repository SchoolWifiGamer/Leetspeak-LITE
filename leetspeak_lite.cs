using System;
using System.Collections.Generic;

namespace LeetSpeakConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leet dictionary
            Dictionary<char, List<string>> leetDict = new Dictionary<char, List<string>>()
            {
                {'A', new List<string> {"4", "/\\", "@", "/-\\", "^", "(L", "Д"}},
                {'B', new List<string> {"I3", "8", "13", "|3", "ß", "!3", "(3", "/3", ")3", "|-]", "j3"}},
                {'C', new List<string> {"[", "¢", "<", "(", "©"}},
                {'D', new List<string> {")", "|)", "(|", "[)", "I>", "|>", "?", "T)", "I7", "cl", "|}", "|]"}},
                {'E', new List<string> {"3", "&", "£", "€", "[-", "|=-"}},
                {'F', new List<string> {"|=", "ƒ", "|#", "ph", "/="}},
                {'G', new List<string> {"6", "&", "(_+", "9", "C-", "gee", "(?,", "[,", "{,", "<-", "(."}},
                {'H', new List<string> {"#", "/-/", "\\-\\", "[-]", "]-[", ")-(", "(-)", ":-:", "|~|", "|-|", "]~[", "}{", "!-!", "1-1", "\\-/", "I+I", "?"}},
                {'I', new List<string> {"1", "|", "][", "!", "eye", "3y3"}},
                {'J', new List<string> {",_|", "_|", "._|", "._]", "_]", ",_]", "]"}},
                {'K', new List<string> {">|", "|<", "1<", "|c", "|(7<"}},
                {'L', new List<string> {"1", "7", "2", "£", "|_", "|"}},
                {'M', new List<string> {"/\\/\\", "/V\\", "[V]", "|\\/|", "^^", "<\\/>", "{V}", "(v)", "(V)", "|\\|", "]\\/[/", "nn", "11"}},
                {'N', new List<string> {"^/", "|\\|", "/\\/", "[\\]", "<\\>", "{\\}", "/V", "^", "ท", "И"}},
                {'O', new List<string> {"0", "()", "oh", "[]", "p", "<>", "Ø"}},
                {'P', new List<string> {"|*", "|o", "|º", "?", "|^", "|>", "|\"", "9", "[]D", "|°", "|7"}},
                {'Q', new List<string> {"(_,)", "()_", "2", "0_", "<|", "&", "9", "¶", "⁋", "℗"}},
                {'R', new List<string> {"I2", "9", "|`", "|~", "|?", "/2", "|^", "lz", "7", "2", "12", "®", "[z", "Я", ".-", "|2", "|-", "3", "4"}},
                {'S', new List<string> {"5", "$", "z", "§", "ehs", "es", "2"}},
                {'T', new List<string> {"7", "+", "-|-", "]['", "†", "«|»", "~|~"}},
                {'U', new List<string> {"(_)", "|_|", "v", "L|", "บ"}},
                {'V', new List<string> {"\\/", "|/", "\\|"}},
                {'W', new List<string> {"\\/\\/", "vv", "\\N", "'//", "\\'", "\\^/", "\\/\\/", "(n)", "\\V/", "\\X/", "\\|/", "\\_|_/", "\\_:_/", "uu", "2u", "\\\\//\\\\//", "พ", "₩", "ω"}},
                {'X', new List<string> {"><", "}{", "ecks", "×", "?", "}{", ")(", "]["}},
                {'Y', new List<string> {"j", "`/", "\\|/", "¥", "\\//`|΄"}},
                {'Z', new List<string> {"2", "7_", "-/_", "%", ">_", "s", "~/_", "-\\_", "-|_"}}
            };

            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            string result = "";

            foreach (char character in text.ToUpper())
            {
                if (leetDict.ContainsKey(character))
                {
                    // Use the first leet replacement
                    result += leetDict[character][0];
                }
                else
                {
                    result += character;
                }
            }

            Console.WriteLine(result);
            
            // Keep console open until key press
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
