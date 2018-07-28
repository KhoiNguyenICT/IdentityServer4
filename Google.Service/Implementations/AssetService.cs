using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Asset;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class AssetService: BaseService<Asset, AssetDto>, IAssetService
    {
        public AssetService(AppDbContext context) : base(context)
        {
        }
    }
}