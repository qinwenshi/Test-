using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SharedLibrary;

namespace Tests
{
    [TestFixture]
    public class CharExtensionTester
    {
        [Test]
        public void can_distinguish_digital()
        {
            char character = '1';
            Assert.IsTrue(character.IsDigit());
        }

        [Test]
        public void can_distinguish_letter()
        {
            char character = 'a';
            Assert.IsTrue(character.IsLetter());
        }

        [Test]
        public void can_distinguish_lower_case_letter()
        {
            char character = 'b';
            Assert.IsTrue(character.IsLower());

            character = 'B';
            Assert.IsFalse(character.IsLower());
        }

        [Test]
        public void can_distinguish_upper_case_letter()
        {
            char character = 'B';
            Assert.IsTrue(character.IsUpper());

            character = 'b';
            Assert.IsFalse(character.IsUpper());
        }

        [Test]
        public void can_distinguish_white_space()
        {
            char character = ' ';
            Assert.IsTrue(character.IsWhiteSpace());

            character = '\r';
            Assert.IsTrue(character.IsWhiteSpace());

            character = '\n';
            Assert.IsTrue(character.IsWhiteSpace());

        }

        [Test]
        public void can_distinguish_letter_or_digital()
        {
            char character = 'a';
            Assert.IsTrue(character.IsLetterOrDigit());

            character = 'A';
            Assert.IsTrue(character.IsLetterOrDigit());

            character = '9';
            Assert.IsTrue(character.IsLetterOrDigit());
        }

        [Test]
        public void can_distinguish_control_char()
        {
            char character = '\r';
            Assert.IsTrue(character.IsControl());

            character = '\n';
            Assert.IsTrue(character.IsControl());

            character = '\b';
            Assert.IsTrue(character.IsControl());
        }

        [Test]
        public void can_distinguish_seperator_char()
        {
            char character = ' ';
            Assert.IsTrue(character.IsSeparator());
        }

        [Test]
        public void can_distinguish_symbol_char()
        {
            char character = '+';
            Assert.IsTrue(character.IsSymbol());
        }
    }
}
