using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestXSS
    {
        [TestMethod]
        [OwnerAttribute("<script>alert(123)</script>")]
        public void TestMethod1()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("<body onload=alert('test1')>")]
        public void TestMethod2()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("<b onmouseover=alert('Wufff!')>click me!</b>")]
        public void TestMethod3()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("<img src=\"http://url.to.file.which/not.exist\" onerror=alert(document.cookie);>")]
        public void TestMethod4()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        [OwnerAttribute("<IMG SRC=j&#X41vascript:alert('test2')>")]
        public void TestMethod5()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner2")]
        public void TestMethod6()
        {
            Assert.IsTrue(true);
        }

        [OwnerAttribute("owner2")]
        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner3")]
        public void TestMethod8()
        {
            Assert.IsTrue(true);
        }


        [TestMethod]
        [OwnerAttribute("owner3")]
        public void TestMethod9()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [OwnerAttribute("owner4")]
        public void TestMethod10()
        {
            Assert.IsTrue(true);
        }
    }
}
