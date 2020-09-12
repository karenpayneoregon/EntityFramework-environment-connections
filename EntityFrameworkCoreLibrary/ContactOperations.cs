using System.Collections.Generic;
using System.Threading.Tasks;
using EntityFrameworkCoreLibrary.Contexts;
using EntityFrameworkCoreLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreLibrary
{
    public class ContactOperations
    {
        public static async Task<List<Contacts>> GetContactsAsync()
        {
            return await Task.Run(async () =>
            {
                using (var context = new NorthWindContext())
                {
                    return await context
                        .Contacts
                        .Include(contact => contact.ContactTypeIdentifierNavigation)
                        .ToListAsync();
                }
            });
        }
    }
}
