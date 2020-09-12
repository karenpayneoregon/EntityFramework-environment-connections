# Entity Framework connection at runtime

This repository shows how to setup connection strings for different environments e.g. development, staging and production. This isolates operations so a developer can develop, testers can test without disturbing the production environment.

Each environment in these cases the database name(s) are the same in each environment while the server name is different for each environment. Security/permissions are different for each environment, virtually no restrictions in development while staging would match production.


### Reverse engineering 

Reverse engineering done for C# using [EF Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools).