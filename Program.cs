using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FikaAmazonAPI.ConstructFeed;
using FikaAmazonAPI.ConstructFeed.Messages;
using FikaAmazonAPI.Parameter.Finance;
using FikaAmazonAPI.Parameter.ListingItem;
using FikaAmazonAPI.Parameter.ListingsItems;
using FikaAmazonAPI.Parameter.Order;
using FikaAmazonAPI.ReportGeneration;
using FikaAmazonAPI.Utils;
using static FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems.ListingsItemPutRequest;
using static FikaAmazonAPI.Utils.Constants;

namespace amazonDataConnector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
