using Google.Service.Dtos.Asset;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Extensions;
using Google.Model.Entities;
using Microsoft.AspNetCore.Hosting;


namespace Google.Application.Controllers
{
    public class AssetController : GoogleController
    {
        private readonly IAssetService _assetService;

        public AssetController(IAssetService assetService, IHostingEnvironment environment)
        {
            _assetService = assetService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var result = await _assetService.UploadAsync(file);
            return Ok(result);
        }
    }
}