﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CourseProject.Infrastructure.MappingProfiles;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CourseProject.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(c => c.AddProfiles(typeof(ProjectMappingProfile)
                , typeof(ContentMappingProfile)
                , typeof(ImageMappingProfile)
                , typeof(CategoryMappingProfile)
                , typeof(ImageMappingProfile)
                , typeof(RewardMappingProfile)
                , typeof(ShowProjectMappingProfile)
                , typeof(UserMappingProfile)
                , typeof(PostMappingProfile)
                , typeof(CommentMappingProfile)));
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
