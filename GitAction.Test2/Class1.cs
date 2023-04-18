using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace GitAction.Test2
{
    public class Class1
    {
        [Test]
        public void Run()
        {
            Assert.AreEqual(1, 0, "Not Equal");
        }
    }
}
