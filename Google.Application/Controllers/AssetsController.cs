using Google.Service.Dtos.Asset;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using Google.Common.Extensions;
using Google.Model.Entities;
using Microsoft.AspNetCore.Hosting;


namespace Google.Application.Controllers
{
    public class AssetsController : GoogleController
    {
        private readonly IAssetService _assetService;
        private readonly IHostingEnvironment _environment;

        public AssetsController(IAssetService assetService, IHostingEnvironment environment)
        {
            _assetService = assetService;
            _environment = environment;
        }

        [HttpPost("upload")]
        public IActionResult Upload(IFormFile file)
        {
            if (file != null)
            {
                var assetDto = file.To<Asset>().To<AssetDto>();
                if (!Directory.Exists(_environment.WebRootPath + "\\uploads\\"))
                {
                    Directory.CreateDirectory(_environment.WebRootPath + "\\uploads\\");
                }
                using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\uploads\\" + assetDto.AssetName))
                {
                    file.CopyTo(filestream);
                    filestream.Flush();
                    _assetService.Add(assetDto);
                    return Ok("/uploads/" + assetDto.AssetName);
                }
            }

            return Ok();
        }
    }
}