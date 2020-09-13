using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameworkCoreLibrary1;
using EntityFrameworkCoreLibrary1.Helpers;
using EntityFrameworkCoreTest.Classes;

namespace EntityFrameworkCoreTest
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Used to create an encrypted connection string.
        /// </summary>
        [TestMethod,
         TestTraits(Trait.EncryptDecryptConnectionString)]
        public void EncryptDecryptString()
        {
            var exposedConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";
            var encrypted = ApplicationConfiguration.Writer(exposedConnectionString);
            Console.WriteLine(encrypted);
            var decrypted = ApplicationConfiguration.Reader(encrypted);
            Console.WriteLine(decrypted);

            Assert.AreEqual(exposedConnectionString,decrypted);
        }

        [TestMethod,
         TestTraits(Trait.EncryptDecryptConnectionString)]
        public async Task DecryptConnectionString()
        {
            var contacts = await ContactOperations.GetContactsAsync();
            Assert.IsTrue(contacts.Count == 91);
        }
    }
}
