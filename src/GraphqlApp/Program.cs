using GraphqlApp;
using GraphqlApp.GraphQL;
using GraphqlApp.HubConfig;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;

var corsPolicyName = "CorsPolicy";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options => 
{ 
    options.AddPolicy(corsPolicyName, corsPolicyBuilder => corsPolicyBuilder
        .WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()); 
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQLServer()
    .AddType<GraphQLTypes.PizzaDoughType>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddFiltering();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UsePlayground(new PlaygroundOptions
    {
        QueryPath = "/api",
        Path = "/playground"
    });
}

app.UseHttpsRedirection();

app.MapGraphQL("/api");

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();
app.MapHub<PizzaDoughHub>("/pizzaDough");

app.Run();