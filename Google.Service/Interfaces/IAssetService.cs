using System.Threading.Tasks;
using Google.Service.Dtos.Asset;
using Microsoft.AspNetCore.Http;

namespace Google.Service.Interfaces
{
    public interface IAssetService: IService<AssetDto>
    {
        Task<AssetDto> Upload(IFormFile file);
    }
}