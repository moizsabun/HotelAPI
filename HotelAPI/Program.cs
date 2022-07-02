var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services    .AddControllers(options => options.EnableEndpointRouting = false);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseMvc();
app.Run();
