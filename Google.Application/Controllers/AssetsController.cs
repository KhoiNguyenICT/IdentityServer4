using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Google.Model.Entities;
using Google.Service.Dtos.Asset;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class AssetsController : GoogleController
    {
        private readonly IAssetService _assetService;

        public class AssetsFile
        {
            public IFormFile File { get; set; }
        }

        public AssetsController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        [HttpPost("upload")]
        public IActionResult Upload(IFormFile file)
        {
            return Ok();
        }
    }
}