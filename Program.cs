using System;
using ZooManagement.DAL.Interfaces;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.BAL.Services;
using ZooManagement.DAL.Repositories;
using ZooManagement.Presentation;
using Microsoft.Extensions.DependencyInjection;
using ZooManagement.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace ZooManagement
{
    class Program
    {
        public static void Main(String[] args)
        {

            var services = new ServiceCollection();

            services.AddDbContext<ZooDbContext>(options => options.UseSqlServer("Server=192.168.1.250,51434;Database=Prashant;User Id=Prashant;Password=Prashant;TrustServerCertificate=True;"));

            services.AddScoped<IAnimalRepository, AnimalRepository>();

            services.AddScoped<IAnimalService, AnimalService>();

            var provider = services.BuildServiceProvider();

            var animalService = provider.GetService<IAnimalService>();
            

            Home.HomePage(animalService);
        }       
    }
}