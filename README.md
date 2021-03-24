# Clean Architecture With Dapper in .NET 5 leveraging Unit of Work and Repository Pattern

There are plenty of examples in GitHub for a working skeleton implementing a clean architecture in .NET.  However, most of them (if not all) use Entity Framework.  Even though, I like EF because it brings a lot of functionality out of the box, I think there are more performant alternatives.  One of them is definitely Dapper.  Now, this library is a Micro ORM, so it is not expected to have all the functionality as EF.  For example: in EF the context provides the unit of work automatically.  In Dapper, we have to deal with transactions ourselves.  So, I created this simple project to showcase the clean architecture (onion approach) with Dapper using the unit of work. I took some of the ideas from other open source repositories like https://github.com/timschreiber/DapperUnitOfWork, because it is important to dispose the connection and transaction when using dependency injection on disposable objects.

## The project uses:
* ASP.NET 5 - Web Api
* Dapper with unit of work for transactions and repository pattern
* Dependency injection
* AutoMapper
* Clean Architecture

I hope this helps ;)
