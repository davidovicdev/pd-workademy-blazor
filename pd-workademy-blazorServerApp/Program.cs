using MudBlazor.Services;
using pd_workademy_blazorServerApp.Common.Services;
using pd_workademy_blazorServerApp.Data;
using pd_workademy_blazorServerApp.Pages.Categories;
using pd_workademy_blazorServerApp.Pages.TodoItems;
using pd_workademy_blazorServerApp.Pages.Users;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddHttpClient();
        builder.Services.AddMudServices();
        builder.Services.AddScoped<CategoryStore>();
        builder.Services.AddScoped<CategoryService>();
        builder.Services.AddScoped<UserService>();
        builder.Services.AddScoped<UserStore>();
        builder.Services.AddScoped<TodoItemStore>();
        builder.Services.AddScoped<TodoItemService>();
        builder.Services.AddScoped<CommonCategoryService>();
        builder.Services.AddScoped<CommonUserService>();

        var app = builder.Build();

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
    }
}