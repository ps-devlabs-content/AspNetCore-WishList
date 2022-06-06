using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();



app.UseHttpsRedirection();
app.UseStaticFiles();



app.UseAuthorization();



app.Run();
