// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// https://learn.microsoft.com/en-us/ef/core/cli/dotnet

// dotnet ef dbcontext scaffold "Data Source=STHQ0118-01;Initial Catalog=FoodyByteDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False" Microsoft.EntityFrameworkCore.SqlServer -o Models -c FoodyByteDbContext --context-dir Data