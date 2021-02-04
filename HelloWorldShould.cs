using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace coding_dojo_csharp
{
    [TestClass]
    public partial class HelloWorldShould
    {
        [TestMethod]
        public void returnHelloWorld(){
            HelloWorld helloWorld = new HelloWorld();
            Assert.AreEqual("Hello World!", helloWorld.helloWorld());
        }
    }
}
