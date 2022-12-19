namespace HotelApi.Models
{
    public class User: Base
    {
        public string FullName { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }    
    }
}
