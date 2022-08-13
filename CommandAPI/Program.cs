WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    _ = app.UseDeveloperExceptionPage();
}
app.UseRouting();
app.UseEndpoints(endpoints => _ = endpoints.MapControllers());
app.Run();
