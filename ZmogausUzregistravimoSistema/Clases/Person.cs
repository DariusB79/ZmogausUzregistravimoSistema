namespace ZmogausUzregistravimoSistema.Clases
{
    public class Person
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }

        public int PersonIdCode { get; set; }
        public int PhoneNr { get; set; }

        public string Email { get; set; }

        public byte[] Picture { get; set; }

        public List<Place> Places = new List<Place>();  
    }
}
