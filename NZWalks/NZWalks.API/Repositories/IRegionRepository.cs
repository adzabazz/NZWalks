using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        //IEnumerable<Region> GetAll(); //synchronous
        Task<IEnumerable<Region>> GetAllAsync(); //can be made asynchronous

        Task<Region> GetAsync(Guid id);

        Task<Region> AddAsync(Region region);

        Task<Region> DeleteAsync(Guid id);

        Task<Region> UpdateAsync(Guid id, Region region);
    }
}
