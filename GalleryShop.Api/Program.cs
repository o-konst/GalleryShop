using Amazon.S3;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddAWSService<IAmazonS3>();
builder.Services.AddDB(builder.Configuration.GetConnectionString("DefaultConnection")!);
builder.Services.AddServices();

// Add CORS policy to allow any origin
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();   
}

// Use CORS policy
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
