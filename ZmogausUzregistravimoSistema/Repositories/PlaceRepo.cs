using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Repositories
{
    public class PlaceRepo : IPlaceRepo
    {
        private readonly RegistrationDbContext _context;


        public PlaceRepo(RegistrationDbContext context)
        {
            _context = context;
        }


        //Place

        public List<Place> GetAllPlaces()
        {
            return _context.Places.ToList();
        }


        public List<Place> GetPlaceById(int id)
        {
            return _context.Places.Where(x => x.Id == id).ToList();
        }


        public Place AddNewPlace(PlaceRequestModel place)
        {
            var newPlace = new Place();
            newPlace.PersonId = place.PersonId;
            newPlace.City = place.City;
            newPlace.Street = place.Street;
            newPlace.HomeNr = place.HomeNr;
            newPlace.FlatNr = place.FlatNr;
            _context.Places.Add(newPlace);
            _context.SaveChanges();

            return newPlace;
        }



        public Place UpdatePlace(int id, PlaceRequestModel place)
        {

            var placeToUpdate = _context.Places.Single(x => x.Id == id);
            placeToUpdate.PersonId = place.PersonId;
            placeToUpdate.City = place.City;
            placeToUpdate.Street = place.Street;
            placeToUpdate.HomeNr = place.HomeNr;
            placeToUpdate.FlatNr = place.FlatNr;
            _context.SaveChanges();

            return placeToUpdate;
        }


        public Place DeletePlace(int id)
        {
            var delPlace = _context.Places.Single(x => x.Id == id);
            _context.Places.Remove(delPlace);
            _context.SaveChanges();

            return delPlace;

        }


        // Update Place information


        public Place UpdatePlaceCity(int id, string city)
        {
            var placeUpdateCity = _context.Places.Single(x => x.Id == id);
            placeUpdateCity.City = city;
            _context.SaveChanges();

            return placeUpdateCity;
        }

        public Place UpdatePlaceStreet(int id, string street)
        {
            var placeUpdateStreet = _context.Places.Single(x => x.Id == id);
            placeUpdateStreet.Street = street;
            _context.SaveChanges();

            return placeUpdateStreet;
        }

        public Place UpdatePlaceHomeNr(int id, int homeNr)
        {
            var placeUpdateHomeNr = _context.Places.Single(x => x.Id == id);
            placeUpdateHomeNr.HomeNr = homeNr;
            _context.SaveChanges();

            return placeUpdateHomeNr;
        }


        public Place UpdatePlaceFlatNr(int id, int flatNr)
        {
            var placeUpdateFlatNr = _context.Places.Single(x => x.Id == id);
            placeUpdateFlatNr.HomeNr = flatNr;
            _context.SaveChanges();

            return placeUpdateFlatNr;
        }

    }
}
