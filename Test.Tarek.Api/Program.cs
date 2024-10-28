using Microsoft.EntityFrameworkCore;
using Test.Tarek.Database.Data;
using Test.Tarek.Logic.Repos;
using Test.Tarek.Logic.Services;

namespace Test.Tarek.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddCors();
            builder.Services.AddControllers();

            //builder.Services.AddCors(options =>
            //{
            //    options.AddDefaultPolicy(
            //        policy =>
            //        {
            //            policy.AllowAnyHeader()
            //                .AllowAnyHeader()
            //                .AllowAnyMethod();
            //        });
            //});

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefCon"));
            });

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepo, UserRepo>();


            //builder.Services.AddCors(options =>
            //{

            //    options.AddDefaultPolicy(
            //        policy =>
            //        {
            //            policy.WithOrigins("https://localhost:7224/")
            //                .AllowAnyHeader()
            //                .AllowAnyMethod();
            //        });
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.Run();
        }
    }
}
