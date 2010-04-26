using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SharedLibrary;

namespace Tests
{
    [TestFixture]
    public class LexerTester
    {
        [Test]
        public void lexer_can_go_through_given_text()
        {
            string testExpression = "test string";
            MyLexer lexer = new MyLexer(testExpression);
            Assert.AreEqual('t', lexer.nextChar());
            Assert.AreEqual('e', lexer.nextChar());
            Assert.AreEqual('s', lexer.nextChar());
            Assert.AreEqual('t', lexer.nextChar());
            Assert.AreEqual(' ', lexer.nextChar());
            Assert.AreEqual('s', lexer.nextChar());
            Assert.AreEqual('t', lexer.nextChar());
            Assert.AreEqual('r', lexer.nextChar());
            Assert.AreEqual('i', lexer.nextChar());
            Assert.AreEqual('n', lexer.nextChar());
            Assert.AreEqual('g', lexer.nextChar());
            Assert.AreEqual(ConstsDefinition.EOF_CHAR, lexer.nextChar());
            Assert.AreEqual(ConstsDefinition.EOF_CHAR, lexer.nextChar());
            Assert.AreEqual(ConstsDefinition.EOF_CHAR, lexer.nextChar());
            Assert.AreEqual(ConstsDefinition.EOF_CHAR, lexer.nextChar());
            Assert.AreEqual(ConstsDefinition.EOF_CHAR, lexer.nextChar());
        }

        [Test]
        public void lexer_can_recognizeTokens()
        {
            string testExpression = "test string";
            MyLexer lexer = new MyLexer(testExpression);
            Token token = lexer.NextToken();
        }
    }

    public class MyLexer : Lexer
    {
        public MyLexer(string expression)
            : base(expression)
        { }

        public char nextChar()
        {
            return this.advance();
        }
    }
}
