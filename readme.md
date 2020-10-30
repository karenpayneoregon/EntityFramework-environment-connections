# Entity Framework connection at runtime

This repository shows how to setup connection strings for different environments e.g. development, staging and production. This isolates operations so a developer can develop, testers can test without disturbing the production environment.

Each environment in these cases the database name(s) are the same in each environment while the server name is different for each environment. Security/permissions are different for each environment, virtually no restrictions in development while staging would match production.

# TechNet

For more information see [the following article](https://social.technet.microsoft.com/wiki/contents/articles/54079.entity-frameworkentity-framework-core-dynamic-connection-strings-c.aspx).


### Reverse engineering 

Reverse engineering done for C# using [EF Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools).

[This repository](https://github.com/karenpayneoregon?tab=repositories)