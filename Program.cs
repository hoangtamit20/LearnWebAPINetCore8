var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add service to the container
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseRouting();
// app.UseAuthentication();
// app.UseAuthorization();

//Routing
// "/shirts"
// app.MapGet("/shirts", () => {
//     return "Reading all the shirts";
// });

// app.MapGet("/shirts/{id}", (int id) => {
//     return $"Reading shirt with ID : {id}";
// });

// app.MapPost("/shirts", () => {
//     return "Creating a shirt.";
// });

// app.MapPut("/shirts/{id}", (int id) => {
//     return $"Updating shirt with ID: {id}";
// });

// app.MapDelete("/shirts/{id}", (int id) => {
//     return $"Deleting shirth with ID : {id}";
// });
app.MapControllers();
app.Run();
