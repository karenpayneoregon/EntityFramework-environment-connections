using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using EntityFramework6Library.Models;

namespace EntityFramework6Library
{
    public class ContactOperations
    {
        public static async Task<List<Contact>> GetContactsAsync()
        {
            return await Task.Run(async () =>
            {
                using (var context = new NorthWindContext())
                {
                    return await context
                        .Contacts
                        .Include(contact => contact.ContactType)
                        .ToListAsync();
                }
            });
        }
    }
}
