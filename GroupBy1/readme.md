# About

Simple GroupBy using EF Core

```csharp
using (var context = new Context())
{
    var results = context.DemoTable.AsEnumerable()
        .Where(demoTable => demoTable.Number > 0 && demoTable.Mark2 >0)
        .GroupBy(item => item.Number)
        .Select(g => new
        {
            Key = g.Key,
            Model = g.Select(demoTable => demoTable).ToList()
        }).ToList();

    foreach (var result in results)
    {
        Console.WriteLine(result.Key);
        foreach (var model in result.Model)
        {
            Console.WriteLine($" {model.Id}, {model.Quantity1}, {model.Mark2}");
        }

        Console.WriteLine();
    }
}
```