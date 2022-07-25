namespace WebApi.Models
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate{ get; set; }
        public bool Gender{ get; set; }
        public string Email{ get; set; }
        public string PhoneNumber{ get; set; }
    }
}
