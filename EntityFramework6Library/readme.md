# About

Intent is to demonstrate one method for setting up connection strings for different environments e.g. development, staging and production.

In the dbContext class, there are three configurations where only one may be active. To activate 

- Under project properties
- Select the Build tab
- For "conditional compilation symbols" add Dev while coding, when set for allowing testing enter Staging and nothing for production.
- Compile and now which symbol is defined (or not) will be used for the current connection string.
 

```csharp
#if Dev
        public NorthWindContext() : base("name=DevConnection")
#elif Staging
        public NorthWindContext() : base("name=StagingConnection")
#else
        public NorthWindContext() : base("name=ProductionConnection")
#endif
        { }

```

In app.config

```xml
<appSettings>
  <!--
  Here server name is the same for all three, each one would be different for a real application while the database
  would be the same typically but if different change the Initial Catalog as needed
  />-->
  <add key="DevConnection" value="Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True" />
  <add key="StagingConnection" value="Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True" />
  <add key="ProductionConnection" value="Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True" />
</appSettings>
```

In the above example change the  'Data Source' property server name to match dev, staging and production. 

**Recommendation**
Create a instruction page for building the application which contains a reminder to set the symbol when changing environments.
