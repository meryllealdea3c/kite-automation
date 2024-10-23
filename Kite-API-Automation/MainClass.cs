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
        public void GetTest()
        {
            Functions.GetResponseCode().Wait();
        }

        [Test]
        public void PostTest()
        {
            Payload payload = new Payload
            {
                Id = 1,
                Name = "test",
            };

            Functions.PostPayload(payload).Wait();
        }

        [Test]
        public void PutTest()
        {
            Payload payload = new Payload
            {
                Id = 1,
                Name = "testing",
            };

            Functions.PutPayload(payload, payload.Id).Wait();
        }

        [Test]
        public void DeleteTest()
        {
            Payload payload = new Payload
            {
                Id = 1
            };

            Functions.DeleteResponse(payload.Id).Wait();
        }
    }
}
