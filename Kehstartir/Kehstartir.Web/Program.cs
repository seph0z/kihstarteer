using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Kehstartir.Infrastructure.MappingProfiles;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Kehstartir.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(c => c.AddProfile(typeof(CompanyMappingProfile)));
            CreateWebHostBuilder(args).Build().Run();
            //int[] someArray = { 1, 2, 3, 4 };
            //int[] someArray1;
            //someArray1 = new int[] { 1, 2, 3, 4 };
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
