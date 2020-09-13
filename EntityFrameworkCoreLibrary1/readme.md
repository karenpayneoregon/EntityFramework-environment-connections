# About

This project demonstrates decrypting a connection string from app.config [seen here](https://github.com/karenpayneoregon/EntityFramework-environment-connections/blob/master/EntityFrameworkCoreLibrary1/app.config#L52).

The encrypted connection string is decrypted using the following class [ApplicationConfiguration](https://github.com/karenpayneoregon/EntityFramework-environment-connections/blob/master/EntityFrameworkCoreLibrary1/Helpers/ApplicationConfiguration.cs) which was taken from [Stackoverflow post](https://stackoverflow.com/questions/202011/encrypt-and-decrypt-a-string-in-c) while this may not suit everyone’s need for securing a connection string then simply swap out for what suits the need of an application.

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer(
            ApplicationConfiguration.Reader(AppSettings["ConnectionString"]));
    }
}
```
To use "as is"
- Add the class [ApplicationConfiguration](https://github.com/karenpayneoregon/EntityFramework-environment-connections/blob/master/EntityFrameworkCoreLibrary1/Helpers/ApplicationConfiguration.cs) to your project or place the code into a class project and reference it in the project which has Entity Framework Core DbContext.
- Add a reference to the same project which contains the DbContext System.Configuration.dll
- Use the [following example](https://github.com/karenpayneoregon/EntityFramework-environment-connections/blob/master/EntityFrameworkCoreTest/UnitTest2.cs#L18) (done in a unit test method but can be in any project type) to encrypt a connection string.
- Write a unit test to ensure the connection string properly decrypts e.g.


```csharp
[TestMethod]
public async Task DecryptConnectionString()
{
    var contacts = await ContactOperations.GetContactsAsync();
    Assert.IsTrue(contacts.Count == 91);
}
```
Backend code

```csharp
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
```


