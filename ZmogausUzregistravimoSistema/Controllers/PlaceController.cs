using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaceController : ControllerBase
    {
        private readonly IPlaceRepo _placeRepo;

        public PlaceController(IPlaceRepo placeRepo)
        {
            _placeRepo = placeRepo;
        }

        //Place



        [HttpGet("GetAllPlaces")]
        public List<Place> GetAllPlaces()
        {
            return _placeRepo.GetAllPlaces();
        }

        [HttpGet("GetPlaceById")]
        public List<Place> GetPlaceById([FromQuery] int id)
        {
            return _placeRepo.GetPlaceById(id);
        }


        [HttpPost("AddNewPlace")]
        public Place AddNewPlace([FromBody] PlaceRequestModel place)
        {
            return _placeRepo.AddNewPlace(place);
        }

        [HttpPut("UpdatePlace")]
        public Place UpdatePlace([FromQuery] int id, [FromBody] PlaceRequestModel place)
        {
            return _placeRepo.UpdatePlace(id, place);
        }

        [HttpDelete("DeletePlace")]
        public Place DeletePlace([FromQuery] int id)
        {
            return _placeRepo.DeletePlace(id);
        }



        // Update Place information

        [HttpPut("UpdatePlaceCity")]
        public Place UpdatePlaceCity([FromQuery] int id, [FromQuery] string city)
        {
            return _placeRepo.UpdatePlaceCity(id, city);
        }

        [HttpPut("UpdatePlaceStreet")]
        public Place UpdatePlaceStreet([FromQuery] int id, [FromQuery] string street)
        {
            return _placeRepo.UpdatePlaceStreet(id, street);
        }

        [HttpPut("UpdatePlaceHomeNr")]
        public Place UpdatePlaceHomeNr([FromQuery] int id, [FromQuery] int homeNr)
        {
            return _placeRepo.UpdatePlaceHomeNr(id, homeNr);
        }

        [HttpPut("UpdatePlaceFlatNr")]
        public Place UpdatePlaceFlatNr([FromQuery] int id, [FromQuery] int flatNr)
        {
            return _placeRepo.UpdatePlaceFlatNr(id, flatNr);
        }
    }
}
