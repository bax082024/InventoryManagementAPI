using InventoryManagementAPI.Services;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddSingleton<IInventoryService, InventoryService();

var app = builder.Build();