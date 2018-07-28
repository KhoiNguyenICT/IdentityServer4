using System.IO;
using System.Threading.Tasks;
using Google.Common.Extensions;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Asset;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Google.Service.Implementations
{
    public class AssetService: BaseService<Asset, AssetDto>, IAssetService
    {
        private readonly IHostingEnvironment _environment;
        public AssetService(AppDbContext context, IHostingEnvironment environment) : base(context)
        {
            _environment = environment;
        }

        public async Task<AssetDto> Upload(IFormFile file)
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
                    await this.Add(assetDto);
                    return assetDto;
                }
            }

            return null;
        }
    }
}