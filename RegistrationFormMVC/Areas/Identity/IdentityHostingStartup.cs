using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegistrationFormMVC.Areas.Identity.Data;
using RegistrationFormMVC.Data;

[assembly: HostingStartup(typeof(RegistrationFormMVC.Areas.Identity.IdentityHostingStartup))]
namespace RegistrationFormMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RegistrationFormMVCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RegistrationFormMVCContextConnection")));

                services.AddDefaultIdentity<RegistrationFormMVCUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<RegistrationFormMVCContext>();
            });
        }
    }
}