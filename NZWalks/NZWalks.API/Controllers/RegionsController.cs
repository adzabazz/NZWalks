using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")] //autopopulates with controller name minus the controller keyword
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]//async of below
        public async Task<IActionResult> GetAllRegions()
        {           
            var regions = await regionRepository.GetAllAsync();
            
            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }


        //[HttpGet]
        //public IActionResult GetAllRegions()
        //{
        //    //var regions = new List<Region>() //placeholder static list
        //    //{
        //    //    new Region
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Name = "Wellington",
        //    //        Code = "WLG",
        //    //        Area = 227755,
        //    //        Lat = -1.8822,
        //    //        Long = 299.88,
        //    //        Population = 500000
        //    //    },
        //    //    new Region
        //    //    {
        //    //        Id = Guid.NewGuid(),
        //    //        Name = "Auckland",
        //    //        Code = "AUCK",
        //    //        Area = 227755,
        //    //        Lat = -1.8822,
        //    //        Long = 299.88,
        //    //        Population = 500000
        //    //    }
        //    //};
        //    var regions = regionRepository.GetAllAsync();
        //    //return DTO regions
        //    //var regionsDTO = new List<Models.DTO.Region>();           
        //    //regions.ToList().ForEach(region =>
        //    //{
        //    //    var regionDTO = new Models.DTO.Region()
        //    //    {
        //    //        Id = region.Id,
        //    //        Name = region.Name,
        //    //        Code = region.Code,
        //    //        Area = region.Area,
        //    //        Lat = region.Lat,
        //    //        Long = region.Long,
        //    //        Population = region.Population,

        //    //    };

        //    //    regionsDTO.Add(regionDTO);
        //    //});

        //    var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

        //    return Ok(regionsDTO);
        //}


    }
}
