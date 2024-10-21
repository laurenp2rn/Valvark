using ShopTARge23.Core.Dto;

namespace ShopTARge23.Core.ServiceInterface
{
    public interface IKindergartensServices
    {
        Task<KindergartenDto> Create(KindergartenDto dto);
        Task<KindergartenDto> Update(KindergartenDto dto);
        Task<KindergartenDto> DetailsAsync(Guid id);
        Task<KindergartenDto> Delete(Guid id);
        Task DeleteImage(Guid imageId);
    }
}
