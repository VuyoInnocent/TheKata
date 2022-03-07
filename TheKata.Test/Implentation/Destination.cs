using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKata.Interface;

namespace TheKata.Test.Domain
{
    public class Destination : IDestination
    {
        public int setCharWasCalled = 0;
        private char character;
        private string outPutString = "";

        public void WriteChar(char c)
        {
            character = c;
            outPutString += character;
            setCharWasCalled++;

        }

        //Extra checks

        public char VerifyCharacter()
        {
            return character;
        }

        public string VerifyString()
        {
            return outPutString;
        }

       
    }
}
