using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TheKata.Interface;
using TheKata.Test.Domain;

namespace TheKata.Test
{
    [TestClass]
    public class TheKataUT
    {
        private readonly Destination destination = new Destination();

        [TestMethod]
        public void Copy_A_Character()
        {

            ISource sourceStub = new Source("a\n");
            Copier copier = new Copier(sourceStub, destination);

            copier.Copy();

            Assert.AreEqual(1, destination.setCharWasCalled);
            Assert.AreEqual('a', destination.VerifyCharacter());
        }
        [TestMethod]
        public void Copy_A_Line_Of_Characters()
        {

            ISource source = new Source("aaaAB" + "\n");
            Copier copier = new Copier(source, destination);

            copier.Copy();

            Assert.AreEqual(5, destination.setCharWasCalled);
            Assert.AreEqual("aaaAB", destination.VerifyString());
        }
    }
}
