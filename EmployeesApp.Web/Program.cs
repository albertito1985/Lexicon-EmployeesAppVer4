using EmployeesApp.Web.Models;
using EmployeesApp.Infrastructure.Persistance.Repositories;
using Employees.Application.Employees;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();


            //builder.Services.AddTransient<EmployeeService>();
            //builder.Services.AddSingleton<EmployeeService>();
            //builder.Services.AddSingleton<IEmployeeService, EmployeeService>();
            //hi
            builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();
            builder.Services.AddScoped<MyLogServiceFilterAttribute>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}