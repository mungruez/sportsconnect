# sportsconnect
AspNetCore 6.0 with EFCore and Angular 16.0.5

The App has Two folders :

sportsconnectB - contains the .net backend


sportsconnectUI - contains the Angular frontend

dotNet SDK 6.0, Node.js 18.16.0, AngularCLI 16.0.5, Entity Framework Core, Data Seeding, FluentValidation.AspNetCore, Swagger endpoint UI for APIs,
        SQL Server 19.1.56, SQL Server management Studio, VSCode(Extensions for C# and Typescript), bootstrap 5.3.3, Windows 11, Docker(SQL server image), GitHub, Google, Youtube. 
        Points to rember, reset the SQL instance once schema has changed in Entity, .net does not allow use of the "event" keyword, Typescript
        does not have a Guid type and it is need for an SQL instance. Alter program.cs file to allow CORS, assemble fluent validation, set the Database Context and enable Swagger.
           

************************************************************************************************************************    ************************************************************************************************************************
        
  A Web Applciation built using ASP .Net Core Web API 6.0 with Entity framework on the backend, and Angular 16.0.5 on the Frontend. Domain Driven Design by introducing a Sports Player Marketplace and Sports Team Management. Players and Events are the current Subdomains. Players and Events are created, read, updated and deleted from separate domains. On one domain functionality can be added for players to message one another, rate their experiences, give ratings, receive points for goals scored and allow coaches to be able to create events and rate teams. The core Domain would be the finding nearby players interested in  the same sport, predictions of events, archiving a history of past events and a beautiful and friendly UI/UX design.

The home page shows all the players, use the nav bar to create a new player. Once a new player is created you will
        be able to view,edit or delete that player from the Players table. Click the 
        "Events" button to see the list of all events that Players have created. On the Events screen
        enter a players ID number to add, update or delete events. The Join and Leave buttons only become
        visible if a Player's id is entered and only owners are allowed to edit owned Events. These features
        make this an awesome start to becoming monolithic.
