Development - Code, unit tests
QA/Tst - Testers (Manual, Automated)
UAT - User Acceptance Testing
Prod - Live version


## Database Access
* EF Core - Entity Framework Core
	* Database-first approach
	* Code-first approach - We will use this one with migrations commands

	1. Install 3 packages: Ef core, Ef core design, Ef core Sqlite
	1. Add dbcontext class
	1. In program.cs
	```
		builder.Services.AddDbContext<AssignmentMgmtDb>(options => 
			options.UseSqlite("Data Source=AssignmentDb.db")
		);
	```
	1. dotnet tool install -g dotnet-ef
	1. dotnet ef migrations add InitalDbCreation(Some sensible migration name)
	1. dotnet ef database update
