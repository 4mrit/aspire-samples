using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var database = builder.AddSqlServerContainer("sqlserver")
    .AddDatabase("appdb");

builder.AddProject<Projects.VolumeMount_BlazorWeb>("blazorweb")
    .WithReference(database);

builder.Build().Run();
