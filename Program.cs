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

            services.AddDbContext<ZooDbContext>();

            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<IAttractionRepository, AttractionRepository>();

            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<IAttractionService, AttractionService>();

            var provider = services.BuildServiceProvider();

            var animalService = provider.GetService<IAnimalService>();
            var AttractionService = provider.GetService<IAttractionService>();
            

            Home.HomePage(animalService, AttractionService);
        }       
    }
}