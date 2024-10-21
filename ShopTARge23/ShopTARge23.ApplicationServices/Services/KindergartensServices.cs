using Microsoft.EntityFrameworkCore;
using ShopTARge23.Core.Domain;
using ShopTARge23.Core.Dto;
using ShopTARge23.Core.ServiceInterface;
using ShopTARge23.Data;

namespace ShopTARge23.ApplicationServices.Services
{
    public class KindergartensServices : IKindergartensServices
    {
        private readonly ShopTARge23Context _context;

        public KindergartensServices(ShopTARge23Context context)
        {
            _context = context;
        }

        public async Task<KindergartenDto> Create(KindergartenDto dto)
        {
            Kindergarten kindergarten = new Kindergarten
            {
                Id = Guid.NewGuid(),
                GroupName = dto.GroupName,
                ChildrenCount = dto.ChildrenCount,
                KindergartenName = dto.KindergartenName,
                Teacher = dto.Teacher,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            await _context.Kindergartens.AddAsync(kindergarten);
            await _context.SaveChangesAsync();

            return MapToDto(kindergarten);
        }

        public async Task<KindergartenDto> DetailsAsync(Guid id)  // Parandatud
        {
            var kindergarten = await _context.Kindergartens
                .FirstOrDefaultAsync(x => x.Id == id);
            return MapToDto(kindergarten);
        }

        public async Task<KindergartenDto> Update(KindergartenDto dto)
        {
            var kindergarten = await _context.Kindergartens.FindAsync(dto.Id);
            if (kindergarten == null) return null;

            kindergarten.GroupName = dto.GroupName;
            kindergarten.ChildrenCount = dto.ChildrenCount;
            kindergarten.KindergartenName = dto.KindergartenName;
            kindergarten.Teacher = dto.Teacher;
            kindergarten.UpdatedAt = DateTime.Now;

            _context.Kindergartens.Update(kindergarten);
            await _context.SaveChangesAsync();

            return MapToDto(kindergarten);
        }

        public async Task<KindergartenDto> Delete(Guid id)
        {
            var kindergarten = await _context.Kindergartens.FindAsync(id);
            if (kindergarten == null) return null;

            _context.Kindergartens.Remove(kindergarten);
            await _context.SaveChangesAsync();

            return MapToDto(kindergarten);
        }

        public async Task DeleteImage(Guid imageId)  // Täidetud meetod
        {
            var image = await _context.FileToDatabases.FindAsync(imageId);
            if (image == null) return;

            _context.FileToDatabases.Remove(image);
            await _context.SaveChangesAsync();
        }

        private KindergartenDto MapToDto(Kindergarten kindergarten)
        {
            return new KindergartenDto
            {
                Id = kindergarten.Id,
                GroupName = kindergarten.GroupName,
                ChildrenCount = kindergarten.ChildrenCount,
                KindergartenName = kindergarten.KindergartenName,
                Teacher = kindergarten.Teacher,
                CreatedAt = kindergarten.CreatedAt,
                UpdatedAt = kindergarten.UpdatedAt
            };
        }
    }
}
