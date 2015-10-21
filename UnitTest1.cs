using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestMethodNullStringArrayException()
        {
            Install objInstall = new Install();
            string[,] str2d=new string[,]
            {
                {"KittenService:","" },
                { "Leetmeme" ,"Cyberportal"},
                {"Cyberportal:","Ice" }
            };
            objInstall.InputStringVal = str2d;
            bool installed=objInstall.VarifyDependency();
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethodIndexofStringOutofRange()
        {

        }
    }
}
