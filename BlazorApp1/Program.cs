using BlazorApp1.Data;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = false; });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();


var app = builder.Build();


//Register Syncfusion license
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY4NjQxMkAzMjMyMmUzMDJlMzBoZHJLM2lpVDZjdDlZV3gxSGNRZm5TYzJhOGpsakI3NHRtZlZ6Rmg4QXZBPQ==");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc5OTY2MUAzMjMzMmUzMDJlMzBIcllJQWJEYWVvWVRXY0ZWYUN5RDFXZDVQYmt4RjY4YnFGdkJBeTlZQ2Z3PQ==");


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
