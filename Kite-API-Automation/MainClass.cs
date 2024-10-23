using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;


namespace Kite_API_Automation
{
    [TestFixture]
    public class MainClass
    {
        [Test]
        public void Test()
        {
            Functions.GetResponseCode().Wait();
        }
    }
}
