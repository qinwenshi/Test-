using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedLibrary
{
    public class Lexer
    {
        public string Expression { get; set; }
        private char[] expressionData;
        private int currentPosition=-1;
        private int expressionLength = 0;

        public Lexer(string expression)
        {
            initializeExpressionData(expression);
            resetCursor();
        }
        
        public Token NextToken()
        {
            return new Token();
        }

        protected char advance()
        {
            moveCursor();
            if (ReachedEnd())
            {
                reverseCursor();
                return ConstsDefinition.EOF_CHAR;
            }
            return expressionData[currentPosition];
        }

        private void initializeExpressionData(string expression)
        {
            Expression = expression;
            expressionData = expression.ToCharArray();
            expressionLength = expressionData.Length;
        }

        private void resetCursor()
        {
            currentPosition = -1;
        }

        private void moveCursor()
        {
            currentPosition++;
        }

        private void reverseCursor()
        {
            currentPosition--;
        }

        private bool ReachedEnd()
        {
            return currentPosition >= expressionLength;
        }
    }
}
