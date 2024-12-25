using Encryptor.AspNetCore.Config;
using Vandar.AspNetCore.DependencyInjection;
using Vandar.Presenter.Models.SettingAggregate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Setting getSettings = null;
builder.Services.AddVandarService(options =>
{
    options.Business = getSettings?.Vandar.Business ?? "";
    options.RefreshToken = getSettings?.Vandar.RefreshToken ?? "";
    options.Token = getSettings?.Vandar.Token ?? "";
    options.BaseUrl = getSettings?.Vandar.BaseUrl ?? "";
    options.IPGSetting = new IPGSetting
    {
        Token = getSettings?.IPG.Token ?? "",
        BaseUrl = getSettings?.IPG.BaseUrl ?? ""
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
