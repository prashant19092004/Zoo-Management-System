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
            services.AddScoped<IDiscountRepository, DiscountRepository>();
            services.AddScoped<IVisitorRepository, VisitorRepository>();
            services.AddScoped<ITicketRepository, TicketReposity>();

            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<IAttractionService, AttractionService>();
            services.AddScoped<IDiscountService, DiscountService>();
            services.AddScoped<IVisitorService, VisitorService>();
            services.AddScoped<ITicketService, TicketService>();

            var provider = services.BuildServiceProvider();

            var animalService = provider.GetService<IAnimalService>();
            var AttractionService = provider.GetService<IAttractionService>();
            var DiscountService = provider.GetService<IDiscountService>();
            var VisitorService = provider.GetService<IVisitorService>();
            var ticketService = provider.GetService<ITicketService>();
            

            Home.HomePage(animalService, AttractionService, DiscountService, VisitorService, ticketService);
        }       
    }
}