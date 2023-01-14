namespace ZmogausUzregistravimoSistema.Clases
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public int PhoneNr { get; set; }

        public string Email { get; set; }

        public string Picture { get; set; }

        public List<Place> Places = new List<Place>();  
    }
}
