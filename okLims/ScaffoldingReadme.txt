Support for ASP.NET Core Identity was added to your project
- The code for adding Identity to your project was generated under Areas/Identity.

Configuration of the Identity related services can be found in the Areas/Identity/IdentityHostingStartup.cs file.


The generated UI requires support for static files. To add static files to your app:
1. Call app.UseStaticFiles() from your Configure method

To use ASP.NET Core Identity you also need to enable authentication. To authentication to your app:
1. Call app.UseAuthentication() from your Configure method (after static files)

The generated UI requires MVC. To add MVC to your app:
1. Call services.AddMvc() from your ConfigureServices method
2. Call app.UseMvc() from your Configure method (after authentication)

Apps that use ASP.NET Core Identity should also use HTTPS. To enable HTTPS see https://go.microsoft.com/fwlink/?linkid=848054.
 "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-okLims6-10F86EC1-A7B9-40B3-A943-2C9C114B0BDE;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;",
//  "defaultConnection": "Server=tcp:oklims.database.windows.net,1433;Initial Catalog=oklimsdb_2019-08-22T22-42Z;Persist Security Info=False;User ID=garbagepatch;Password=QzpM!05^;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"