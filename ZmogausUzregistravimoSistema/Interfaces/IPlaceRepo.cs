using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Interfaces
{
    public interface IPlaceRepo
    {

        // Place

        List<Place> GetAllPlaces();

        List<Place> GetPlaceById(int id);

        Place AddNewPlace(PlaceRequestModel place);


        Place UpdatePlace(int id, PlaceRequestModel place);

        Place DeletePlace(int id);




        // Update Place information


        public Place UpdatePlaceCity(int id, string city);


        public Place UpdatePlaceStreet(int id, string street);

        public Place UpdatePlaceHomeNr(int id, int homeNr);


        public Place UpdatePlaceFlatNr(int id, int flatNr);
    }
}
