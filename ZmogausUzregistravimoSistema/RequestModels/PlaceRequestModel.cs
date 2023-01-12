namespace ZmogausUzregistravimoSistema.RequestModels
{
    public class PlaceRequestModel
    {
        public int PersonId { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int HomeNr { get; set; }

        public int FlatNr { get; set; }
    }
}
