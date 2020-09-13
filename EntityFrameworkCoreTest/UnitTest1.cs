using System.Threading.Tasks;
using EntityFrameworkCoreLibrary;
using EntityFrameworkCoreTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkCoreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,
         TestTraits(Trait.EnvironmentConnections)]
        public async Task TestEntityFrameworkCore()
        {
            var contacts = await ContactOperations.GetContactsAsync();
            Assert.IsTrue(contacts.Count == 91);
        }
    }
}
