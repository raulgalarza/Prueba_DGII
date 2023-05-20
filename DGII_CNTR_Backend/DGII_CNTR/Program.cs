using DGII_CNTR.ContextDB;
using Microsoft.EntityFrameworkCore;
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<DgiiDbContext>(options => options.UseSqlServer
                                                (builder.Configuration.GetConnectionString("DGII_CNTRConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                           policy =>
                           {
                               policy.AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowAnyOrigin();
                           });
});

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
