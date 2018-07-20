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

        public AppInitializer(
            IConfiguration configuration,
            AppDbContext context, 
            UserManager<Account> userManager, 
            IChannelService channelService)
        {
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
            _channelService = channelService;
        }

        public async Task InitAsync()
        {
            await _context.Database.MigrateAsync();
            await InitAccount();
        }

        private string CreatePath(string jsonFile)
        {
            return "Configurations/Initializes/" + jsonFile;
        }

        private async Task InitAccount()
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
            var result = await _userManager.CreateAsync(account, _configuration["DefaultAdminAccount:Password"]);
            result = await _userManager.AddToRoleAsync(account, Roles.Administrator);
        }
    }
}