using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Google.Application.Extensions;
using Google.Common.Constants;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Google.Application.Configurations.Systems
{
    public class AppInitializer : IWebHostInitializer
    {
        private readonly UserManager<Account> _userManager;
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;
        private readonly IChannelService _channelService;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AppInitializer(
            IConfiguration configuration,
            AppDbContext context, 
            UserManager<Account> userManager, 
            IChannelService channelService, 
            RoleManager<ApplicationRole> roleManager)
        {
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
            _channelService = channelService;
            _roleManager = roleManager;
        }

        public async Task InitAsync()
        {
            await _context.Database.MigrateAsync();
            await CreateRoles();
            await CreateDefaultAdminAccount();
        }

        private string CreatePath(string jsonFile)
        {
            return "Configurations/Initializes/" + jsonFile;
        }

        private async Task CreateRoles()
        {
            var currentRoles = await _roleManager.Roles.Select(t => t.Name).ToListAsync();
            var roles = typeof(Roles).GetTypeInfo()
                .GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Select(t =>
                {
                    var name = t.GetValue(null) as string;
                    return new ApplicationRole()
                    {
                        Name = name
                    };
                });
            foreach (var item in roles)
            {
                if (currentRoles.Contains(item.Name))
                    continue;
                await _roleManager.CreateAsync(item);
            }
        }

        private async Task CreateDefaultAdminAccount()
        {
            var account = _configuration.GetSection("DefaultAdminAccount").Get<Account>();
            if (account is null)
            {
                return;
            }
            account.UserName = account.Email;
            account.IsActive = true;
            if (await _userManager.FindByEmailAsync(account.Email) != null)
            {
                return;
            }
            await _userManager.CreateAsync(account, _configuration["DefaultAdminAccount:Password"]);
            await _userManager.AddToRoleAsync(account, Roles.Administrator);
        }
    }
}