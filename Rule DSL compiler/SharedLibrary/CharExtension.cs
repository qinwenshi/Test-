using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedLibrary
{
    public static class CharExtension
    {
        public static bool IsDigit(this char chararcter)
        {
            return char.IsDigit(chararcter);
        }

        public static bool IsLetter(this char chararcter)
        {
            return char.IsLetter(chararcter);
        }

        public static bool IsLower(this char chararcter)
        {
            return char.IsLower(chararcter);
        }

        public static bool IsUpper(this char chararcter)
        {
            return char.IsUpper(chararcter);
        }

        public static bool IsWhiteSpace(this char chararcter)
        {
            return char.IsWhiteSpace(chararcter);
        }

        public static bool IsLetterOrDigit(this char chararcter)
        {
            return char.IsLetterOrDigit(chararcter);
        }

        public static bool IsControl(this char chararcter)
        {
            return char.IsControl(chararcter);
        }

        public static bool IsSeparator(this char chararcter)
        {
            return char.IsSeparator(chararcter);
        }

        public static bool IsSymbol(this char chararcter)
        {
            return char.IsSymbol(chararcter);
        }
    }
}
