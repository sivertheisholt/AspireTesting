var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.AspireTest_ApiService>("apiservice");

builder.AddProject<Projects.AspireTest_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
