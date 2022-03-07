using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKata.Interface;

namespace TheKata
{
    public class Copier
    {
        private ISource src;
        private IDestination dest;

        public Copier(ISource src, IDestination dest)
        {
            this.src = src;
            this.dest = dest;

        }
        public void Copy() {
            while (true)
            {
                char aChar = src.ReadChar();
                if (aChar =='\n')
                {
                    break;
                }

                dest.WriteChar(aChar);  
            }
        }
    }
}
