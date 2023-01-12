using ZmogausUzregistravimoSistema.Clases;

namespace ZmogausUzregistravimoSistema.RequestModels
{
    public class PersonRequestModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int PersonIdCode { get; }

        public int PhoneNr { get; set; }

        public string Email { get; set; }

        public string Picture { get; set; }

        public List<Place> Places = new List<Place>();
    }
}
