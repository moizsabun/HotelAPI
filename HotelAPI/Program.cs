using HotelAPI.DA;
using HotelAPI.Service;
using HotelAPI.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddControllers(options => options.EnableEndpointRouting = false);


builder.Services.AddDbContextPool<AppDBContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("HotelBookingAPI"),
   b => b.MigrationsAssembly("HotelAPI")));

builder.Services.AddScoped<IListAllHotel, ListAllHotelsService>();
builder.Services.AddScoped<ISearchHotel, SearchHotelViaIDService>();

builder.Services.AddScoped<IAddBooking, AddBookingService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseMvc();
app.Run();
