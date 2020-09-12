using System.Threading.Tasks;
using EntityFrameworkCoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkCoreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestEntityFrameworkCore()
        {
            var contacts = await ContactOperations.GetContactsAsync();
            Assert.IsTrue(contacts.Count == 91);
        }
    }
}
