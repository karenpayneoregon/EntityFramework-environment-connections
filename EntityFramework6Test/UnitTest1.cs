using System.Threading.Tasks;
using EntityFramework6Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework6Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestEntityFramework6()
        {
            var contacts = await ContactOperations.GetContactsAsync();
            Assert.IsTrue(contacts.Count == 91);
        }
    }
}
