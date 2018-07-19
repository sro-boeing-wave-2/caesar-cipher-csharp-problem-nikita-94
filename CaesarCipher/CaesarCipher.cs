using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            return string.Join("", text.ToCharArray().Select(ch => RotateChar(ch, shiftKey)));
            throw new NotImplementedException("You need to implement this function.");
        }
        private static char RotateChar(char ch, int shiftKey)
        {
            if (!char.IsLetter(ch)) return ch;
            char _base = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((ch - _base + shiftKey) % 26 + _base);
        }
    }
}
