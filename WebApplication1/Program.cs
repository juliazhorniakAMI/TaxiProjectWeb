using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiProject_2._1.Repository;
using TaxiAdmin;
using TaxiProject_2._1.Models;
using System.Diagnostics;
using WebApplication1;


namespace WebApplication1
{
    public class Program

    {
       

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();


            CommandController com = new CommandController();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.UseStartup<Startup>();
                   });
    }
}
