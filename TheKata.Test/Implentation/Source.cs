using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKata.Interface;

namespace TheKata.Test.Domain
{
    class Source : ISource
    {
        private string input;
        private int inputCharacterCounter = 0;

        public Source(string input)
        {
            this.input = input;
        }

        public char ReadChar()
        {
            return input[inputCharacterCounter++];
        }
    }
}
