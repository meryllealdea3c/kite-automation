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
        public void VerifyGetRecord()
        {
            Functions.GetRecord().Wait();
        }

        [Test]
        public void VerifyCreateRecord()
        {
            Payload payload = new Payload
            {
                Id = 1,
                Name = "test",
            };

            Functions.CreateRecord(payload).Wait();
        }

        [Test]
        public void VerifyUpdateRecrd()
        {
            Payload payload = new Payload
            {
                Id = 1,
                Name = "testing",
            };

            Functions.UpdateRecord(payload, payload.Id).Wait();
        }

        [Test]
        public void VerifyDeleteRecord()
        {
            Payload payload = new Payload
            {
                Id = 1
            };

            Functions.DeleteRecord(payload.Id).Wait();
        }
    }
}
